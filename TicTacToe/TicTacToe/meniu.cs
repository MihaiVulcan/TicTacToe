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
    public partial class meniu : Form
    {
        public meniu()
        {
            InitializeComponent();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            PvsP f = new PvsP();
            f.ShowDialog();
        }

        private void bt1p_Click(object sender, EventArgs e)
        {
            PvsPC f = new PvsPC();
            f.ShowDialog();
        }

        private void leaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard lb = new Leaderboard();
            lb.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect atestat 2019 Vulcan Mihai-Aron\nProfesor coordonator Madalina Sibisan");
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The game is played on a grid that's 3 squares by 3 squares.\n" + 
                "2. You are X, your friend (or the computer) is O. Players take turns putting their marks in empty squares.\n" +
                "3. The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.\n" +
                "4. When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.\n" +
                "5. The player(or the computer) who wins starts the next game. If the game ends in a tie the player who starts the game switches");
        }
    }
}
