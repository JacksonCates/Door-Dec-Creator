using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

/* Class Name: Excel
 * Author: Jackson Cates
 * 
 * Description:
 * This class simply allows the user to read in cells from an excel sheet.
 * 
 */ 

namespace DoorDecCreator
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            // Sets the path, workbook, and worksheet
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        ~Excel()
        {
            // Closes
            wb.Close();
        }

        public string ReadCell(int i, int j)
        {
            // Checks to see if the space is empty
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else
            {
                // Is empty, treat as empty string
                return "";
            }
        }

        public void Close()
        {
            wb.Close();
        }
    }
}
