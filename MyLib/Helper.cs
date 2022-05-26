using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Helper
    {

        private string path = @"C:\univer\2 курс\2 сем\рпвс\курсовая\DragonCurve\DragonCurve\Resources\";

        public void openCurveWord()
        {
            System.Diagnostics.Process.Start(path + "DragonCurveWord.docx");
        }

        public void openCurverExcel()
        {
            System.Diagnostics.Process.Start(path + "Excel.xls");
        }

        public void openFractalWord()
        {
            System.Diagnostics.Process.Start(path + "DragonFractal.docx");
        }

        public void openFractalExcel()
        {
            System.Diagnostics.Process.Start(path + "Dragon.xls");
        }

    }
}
