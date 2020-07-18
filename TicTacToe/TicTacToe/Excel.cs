using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace TicTacToe
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path , int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string getString(int i, int j)
        {
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Text;
            return null;
        }

        public int getInt(int i, int j)
        {
            if (ws.Cells[i, j].Value2 != null)
                return Convert.ToInt32(ws.Cells[i, j].Value);
            return 0;
        }

        public void writeString(int i, int j, string s)
        {
            ws.Cells[i, j].Value2 = s;
        }

        public void writeInt(int i, int j, int s)
        {
            ws.Cells[i, j].Value2 = s;
        }

        public void sort()
        {
            dynamic allDataRange = ws.UsedRange;
            allDataRange.Sort(allDataRange.Columns[2], _Excel.XlSortOrder.xlDescending);
        }

        public void close()
        {
            wb.Save();
            wb.Close();
            excel.Quit();
        }

    }
}
