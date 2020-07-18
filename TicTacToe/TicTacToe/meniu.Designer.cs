namespace TicTacToe
{
    partial class meniu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt2p = new System.Windows.Forms.Button();
            this.bt1p = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.leaderboard = new System.Windows.Forms.Button();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bt2p
            // 
            this.bt2p.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt2p.FlatAppearance.BorderSize = 0;
            this.bt2p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2p.Location = new System.Drawing.Point(92, 228);
            this.bt2p.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt2p.Name = "bt2p";
            this.bt2p.Size = new System.Drawing.Size(188, 49);
            this.bt2p.TabIndex = 1;
            this.bt2p.Text = "2 Players";
            this.bt2p.UseVisualStyleBackColor = false;
            this.bt2p.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt1p
            // 
            this.bt1p.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt1p.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt1p.FlatAppearance.BorderSize = 0;
            this.bt1p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1p.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1p.Location = new System.Drawing.Point(92, 162);
            this.bt1p.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt1p.Name = "bt1p";
            this.bt1p.Size = new System.Drawing.Size(188, 49);
            this.bt1p.TabIndex = 2;
            this.bt1p.Text = "1 Player";
            this.bt1p.UseVisualStyleBackColor = false;
            this.bt1p.Click += new System.EventHandler(this.bt1p_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Maroon;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(92, 359);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(188, 49);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // leaderboard
            // 
            this.leaderboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.leaderboard.FlatAppearance.BorderSize = 0;
            this.leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboard.Location = new System.Drawing.Point(92, 294);
            this.leaderboard.Margin = new System.Windows.Forms.Padding(0);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(188, 49);
            this.leaderboard.TabIndex = 4;
            this.leaderboard.Text = "Leaderboard";
            this.leaderboard.UseVisualStyleBackColor = false;
            this.leaderboard.Click += new System.EventHandler(this.leaderboard_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "TicTacToe";
            // 
            // meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bt1p);
            this.Controls.Add(this.bt2p);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bt2p;
        private System.Windows.Forms.Button bt1p;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button leaderboard;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}