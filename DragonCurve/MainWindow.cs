using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Image = Xceed.Document.NET.Image;
using Excel = Microsoft.Office.Interop.Excel;
using MyLib;
using System.IO;

namespace DragonCurve
{
    public partial class MainWindow : Form
    {

        private string path = @"C:\univer\2 курс\2 сем\рпвс\курсовая\DragonCurve\DragonCurve\Resources\";
        Graphics gr;
        Helper hp = new Helper();

        public MainWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void valueBar_Scroll(object sender, EventArgs e)
        {

            valueLable.Text = "Value: " + valueBar.Value.ToString();
        }

        private void drawBt_Click(object sender, EventArgs e)
        {
            Pen Pen1 = new Pen(Color.White, 1);
            Pen Pen2 = new Pen(Color.Pink, 1);
            Pen Pen3 = new Pen(Color.Purple, 1);

            gr = pictureBox.CreateGraphics();
            gr.Clear(Color.Black);

            Draw(pictureBox.Width, pictureBox.Height, gr, Pen1);
            Draw(pictureBox.Width - 400, pictureBox.Height, gr, Pen2);
            Draw(pictureBox.Width + 400, pictureBox.Height, gr, Pen3);

        }

        private void Draw(int w, int h, Graphics gr, Pen pen)
        {
            int iterarions = (int)valueBar.Value;
            int size = 150;

            PointF[] points =
            {
                new PointF(w/2, h/3),
                new PointF(w/2, h/3 + size)
            };
            Dragon(iterarions, points, gr, pen);
        }

        private void Dragon(int iter, PointF[] points, Graphics g, Pen pen)
        {
            float dx, dy;

            if (iter == 0)
                g.DrawLine(pen, points[0], points[1]);
            else
            {
                dx = (points[1].X + points[0].X) / 2 + (points[1].Y - points[0].Y) / 2;
                dy = (points[1].Y + points[0].Y) / 2 - (points[1].X - points[0].X) / 2;
                PointF[] point1 =
                {
                    new PointF(points[0].X, points[0].Y),
                    new PointF(dx, dy)
                };
                PointF[] point2 =
                {
                    new PointF(points[1].X, points[1].Y),
                    new PointF(dx, dy)
                };
                Dragon(iter - 1, point1, g, pen);
                Dragon(iter - 1, point2, g, pen);
            }
        }

        private void wordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {   
                hp.openWord();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                hp.openExcel();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) drawBt.PerformClick();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path + "HelpManual.chm");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have latest version");
        }

        private void thisVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version v.1.2.0");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(670, 240, 910, 600);
            Bitmap image = new Bitmap(910, 600);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            image.Save(path + "DragonCurve.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //сохранение в Word
            string imageDoc = path + "DragonCurve.jpg";
            string doc = path + "DragonCurveWord.docx";

            DocX document = DocX.Create(doc);//создаем документ
            document.InsertParagraph("Сложность = " + (int)valueBar.Value).Font("Times New Roman").
                                                                                 FontSize(16).
                                                                                 Color(Color.Purple);
            Paragraph paragraph = document.InsertParagraph();
            Image imageSave = document.AddImage(imageDoc);
            var t = (int)valueBar.Value;
            var p = path;
            Paragraph paragraph2 = document.InsertParagraph();
            paragraph2.AppendPicture(imageSave.CreatePicture());   // вставка изображения в параграф
            paragraph2.Alignment = Alignment.left; // по центру

            document.Save();

            string excelSave = path + "Excel.xls";
            Excel.Application excel = new Excel.Application(); //объявляем приложение         
            Excel.Workbook workBook; // Создаём экземпляр рабочий книги Excel
            Excel.Worksheet workSheet;// Создаём экземпляр листа Excel

            workBook = excel.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Cells[1, 1] = "Cложность";
            workSheet.Cells[2, 1] = (int)valueBar.Value;
            workSheet.Shapes.AddPicture(imageDoc, Microsoft.Office.Core.MsoTriState.msoFalse,
                                Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 30, 350, 250);
            excel.DefaultFilePath = excelSave;
            excel.DisplayAlerts = false;
            workBook.SaveAs(excelSave, Excel.XlFileFormat.xlWorkbookNormal,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Excel.XlSaveAsAccessMode.xlExclusive,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
            excel.Quit();
        }

        private void aboutProgramDragonCurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram pr = new AboutProgram();
            pr.Show();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Загрузить предыдущее сохранение?", "Загрузка",
                                                        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                valueBar.Value = Properties.Settings.Default.Value;
                valueLable.Text = "Value: " + valueBar.Value.ToString();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(MessageBox.Show("Сохраненить данные?", "Загрузка",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.Value = valueBar.Value;
                Properties.Settings.Default.Save();

            }
        }
    }
}
