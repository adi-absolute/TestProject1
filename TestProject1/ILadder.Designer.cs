namespace Project1
{
    partial class ILadder
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
            this.button_AddGame = new System.Windows.Forms.Button();
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.listBox_PlayerList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddGame
            // 
            this.button_AddGame.Location = new System.Drawing.Point(45, 24);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(75, 23);
            this.button_AddGame.TabIndex = 0;
            this.button_AddGame.Text = "Add Game";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(309, 24);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(75, 23);
            this.button_AddPlayer.TabIndex = 1;
            this.button_AddPlayer.Text = "Add Player";
            this.button_AddPlayer.UseVisualStyleBackColor = true;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // listBox_PlayerList
            // 
            this.listBox_PlayerList.FormattingEnabled = true;
            this.listBox_PlayerList.Location = new System.Drawing.Point(278, 62);
            this.listBox_PlayerList.Name = "listBox_PlayerList";
            this.listBox_PlayerList.Size = new System.Drawing.Size(149, 238);
            this.listBox_PlayerList.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLadderToolStripMenuItem,
            this.loadLadderToolStripMenuItem,
            this.saveLadderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newLadderToolStripMenuItem
            // 
            this.newLadderToolStripMenuItem.Enabled = false;
            this.newLadderToolStripMenuItem.Name = "newLadderToolStripMenuItem";
            this.newLadderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newLadderToolStripMenuItem.Text = "New Ladder";
            // 
            // loadLadderToolStripMenuItem
            // 
            this.loadLadderToolStripMenuItem.Enabled = false;
            this.loadLadderToolStripMenuItem.Name = "loadLadderToolStripMenuItem";
            this.loadLadderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadLadderToolStripMenuItem.Text = "Load Ladder";
            // 
            // saveLadderToolStripMenuItem
            // 
            this.saveLadderToolStripMenuItem.Enabled = false;
            this.saveLadderToolStripMenuItem.Name = "saveLadderToolStripMenuItem";
            this.saveLadderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveLadderToolStripMenuItem.Text = "Save Ladder";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ILadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 417);
            this.Controls.Add(this.listBox_PlayerList);
            this.Controls.Add(this.button_AddPlayer);
            this.Controls.Add(this.button_AddGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ILadder";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddGame;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.ListBox listBox_PlayerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

