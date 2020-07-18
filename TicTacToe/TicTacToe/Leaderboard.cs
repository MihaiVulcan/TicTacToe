using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        public void swap(string s1, string s2)
        {
            string aux = s1;
            s1 = s2;
            s2 = s1;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetFiles(@"D:\info\Visual Studio\TicTacToe\TicTacToe\res", "*.xlsx").Single();
            Excel excel = new Excel(path, 1);

            int n = 1;
            while (excel.getString(n, 1) != null)
                n++;

            /*int sch = 1;
            while (sch == 1)
            {
                sch = 0;
                for (int i = 1; i < n-1; i++)
                {
                    if (excel.getInt(i, 2) < excel.getInt(i + 1, 2))
                    {
                        swap(excel.getString(i, 1), excel.getString(i + 1, 1));
                        swap(excel.getString(i, 2), excel.getString(i + 1, 2));
                        swap(excel.getString(i, 3), excel.getString(i + 1, 3));
                        swap(excel.getString(i, 4), excel.getString(i + 1, 4));
                        sch = 1;
                    }
                }
            }*/

            excel.sort();

            name1.Text = excel.getString(1, 1);
            win1.Text = excel.getString(1, 2);
            lose1.Text = excel.getString(1, 4);

            name2.Text = excel.getString(2, 1);
            win2.Text = excel.getString(2, 2);
            lose2.Text = excel.getString(2, 4);

            name3.Text = excel.getString(3, 1);
            win3.Text = excel.getString(3, 2);
            lose3.Text = excel.getString(3, 4);

            excel.close();
        }
    }
}
