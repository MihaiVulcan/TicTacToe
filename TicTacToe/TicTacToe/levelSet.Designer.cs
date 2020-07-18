namespace TicTacToe
{
    partial class levelSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Lime;
            this.easy.FlatAppearance.BorderSize = 0;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(112, 180);
            this.easy.Margin = new System.Windows.Forms.Padding(2);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(150, 45);
            this.easy.TabIndex = 1;
            this.easy.Text = "EASY";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.btClick);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.Orange;
            this.medium.FlatAppearance.BorderSize = 0;
            this.medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.Location = new System.Drawing.Point(112, 239);
            this.medium.Margin = new System.Windows.Forms.Padding(2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(150, 45);
            this.medium.TabIndex = 2;
            this.medium.Text = "MEDIUM";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.btClick);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Red;
            this.hard.FlatAppearance.BorderSize = 0;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(112, 303);
            this.hard.Margin = new System.Windows.Forms.Padding(2);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(150, 45);
            this.hard.TabIndex = 3;
            this.hard.Text = "HARD";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.btClick);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.SteelBlue;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(80, 358);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(208, 72);
            this.play.TabIndex = 4;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 37);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select difficulty";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to meniu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // levelSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "levelSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}