using System;
using System.Drawing;
using System.IO;

namespace helper
{
    public class helper
    {

        private string path = @"C:\univer\2 курс\2 сем\рпвс\курсовая\";

        public void openWord()
        {
            System.Diagnostics.Process.Start(path + "DragonCurveWord.docx");
        }
       
    }
}
