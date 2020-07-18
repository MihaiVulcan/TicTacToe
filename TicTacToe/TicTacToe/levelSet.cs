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
    public partial class levelSet : Form
    {
        public levelSet()
        {
            InitializeComponent();
        }
        int level = 0;//1-easy 2-medium 3-hard

        private void btClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "EASY")
                level = 1;
            if (b.Text == "MEDIUM")
                level = 2;
            if (b.Text == "HARD")
                level = 3;
            PvsPC.setLevel(level);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PvsPC.setName(textBox2.Text);
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
                MessageBox.Show("introduceti numele");
            else
            {
                if (level == 0)
                    MessageBox.Show("selectati nivelul");
                else
                    this.Close();
            }
            //this.Close();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
