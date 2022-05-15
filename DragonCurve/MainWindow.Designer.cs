
namespace DragonCurve
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.valueBar = new System.Windows.Forms.TrackBar();
            this.valueLable = new System.Windows.Forms.Label();
            this.drawBt = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutProgramDragonCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Location = new System.Drawing.Point(345, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(922, 622);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // valueBar
            // 
            this.valueBar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.valueBar.Location = new System.Drawing.Point(38, 238);
            this.valueBar.Maximum = 13;
            this.valueBar.Minimum = 1;
            this.valueBar.Name = "valueBar";
            this.valueBar.Size = new System.Drawing.Size(261, 69);
            this.valueBar.TabIndex = 2;
            this.valueBar.Value = 1;
            this.valueBar.Scroll += new System.EventHandler(this.valueBar_Scroll);
            // 
            // valueLable
            // 
            this.valueLable.AutoSize = true;
            this.valueLable.Location = new System.Drawing.Point(127, 124);
            this.valueLable.Name = "valueLable";
            this.valueLable.Size = new System.Drawing.Size(67, 20);
            this.valueLable.TabIndex = 3;
            this.valueLable.Text = "Value: 1";
            // 
            // drawBt
            // 
            this.drawBt.Location = new System.Drawing.Point(72, 378);
            this.drawBt.Name = "drawBt";
            this.drawBt.Size = new System.Drawing.Size(226, 85);
            this.drawBt.TabIndex = 4;
            this.drawBt.Text = "Draw";
            this.drawBt.UseVisualStyleBackColor = true;
            this.drawBt.Click += new System.EventHandler(this.drawBt_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem1,
            this.excelToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // wordToolStripMenuItem1
            // 
            this.wordToolStripMenuItem1.Name = "wordToolStripMenuItem1";
            this.wordToolStripMenuItem1.Size = new System.Drawing.Size(159, 34);
            this.wordToolStripMenuItem1.Text = "Word";
            this.wordToolStripMenuItem1.Click += new System.EventHandler(this.wordToolStripMenuItem1_Click);
            // 
            // excelToolStripMenuItem1
            // 
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(159, 34);
            this.excelToolStripMenuItem1.Text = "Excel";
            this.excelToolStripMenuItem1.Click += new System.EventHandler(this.excelToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVersionToolStripMenuItem,
            this.thisVersionToolStripMenuItem,
            this.aboutProgramDragonCurveToolStripMenuItem});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            // 
            // newVersionToolStripMenuItem
            // 
            this.newVersionToolStripMenuItem.Name = "newVersionToolStripMenuItem";
            this.newVersionToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
            this.newVersionToolStripMenuItem.Text = "New Version";
            this.newVersionToolStripMenuItem.Click += new System.EventHandler(this.newVersionToolStripMenuItem_Click);
            // 
            // thisVersionToolStripMenuItem
            // 
            this.thisVersionToolStripMenuItem.Name = "thisVersionToolStripMenuItem";
            this.thisVersionToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
            this.thisVersionToolStripMenuItem.Text = "This version";
            this.thisVersionToolStripMenuItem.Click += new System.EventHandler(this.thisVersionToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutProgramDragonCurveToolStripMenuItem
            // 
            this.aboutProgramDragonCurveToolStripMenuItem.Name = "aboutProgramDragonCurveToolStripMenuItem";
            this.aboutProgramDragonCurveToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
            this.aboutProgramDragonCurveToolStripMenuItem.Text = "About program Dragon Curve";
            this.aboutProgramDragonCurveToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramDragonCurveToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 729);
            this.Controls.Add(this.drawBt);
            this.Controls.Add(this.valueLable);
            this.Controls.Add(this.valueBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Curve";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.Label valueLable;
        private System.Windows.Forms.Button drawBt;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisVersionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramDragonCurveToolStripMenuItem;
    }
}

