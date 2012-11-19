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
            this.SuspendLayout();
            // 
            // button_AddGame
            // 
            this.button_AddGame.Location = new System.Drawing.Point(32, 277);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(75, 23);
            this.button_AddGame.TabIndex = 0;
            this.button_AddGame.Text = "Add Game";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(351, 277);
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
            this.listBox_PlayerList.Location = new System.Drawing.Point(351, 23);
            this.listBox_PlayerList.Name = "listBox_PlayerList";
            this.listBox_PlayerList.Size = new System.Drawing.Size(83, 238);
            this.listBox_PlayerList.TabIndex = 2;
            // 
            // ILadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 417);
            this.Controls.Add(this.listBox_PlayerList);
            this.Controls.Add(this.button_AddPlayer);
            this.Controls.Add(this.button_AddGame);
            this.Name = "ILadder";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddGame;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.ListBox listBox_PlayerList;

    }
}

