using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Gotebuggarna
    {
        private bool running;

        public Gotebuggarna()
        {
            running = false;
        }

        private void GetDataFromLink()
        {
            string urlAddress = "https://docs.google.com/spreadsheets/d/1OBbo8KQvtJaDHkG7gVHKCZULfzQ3DjygSfUjSB5WDf8/edit?usp=sharing";
            
var gsh = new GoogleSheetsHelper.GoogleSheetsHelper("Google Sheets-e1ceb012eb0c.json", "18p6CMRLbN6L4IViUIbAxce_3ij6HGlPYXkKUPR5ZkGo");
            var gsp = new GoogleSheetParameters() { RangeColumnStart = 1, RangeRowStart = 1, RangeColumnEnd = 3, RangeRowEnd = 100, FirstRowIsHeaders = true, SheetName = "sheet1" };
            var rowValues = gsh.GetDataFromSheet(gsp);
        }
        }

        public void Run()
        {
            while (true)
            {
                GetDataFromLink();
                Console.ReadKey();
            }
        }
    }
}
