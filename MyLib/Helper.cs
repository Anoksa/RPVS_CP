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

        public void openWord()
        {
            System.Diagnostics.Process.Start(path + "DragonCurveWord.docx");
        }

        public void openExcel()
        {
            System.Diagnostics.Process.Start(path + "Excel.xls");
        }



    }
}
