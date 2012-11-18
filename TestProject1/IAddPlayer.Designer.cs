namespace Project1
{
    partial class IAddPlayer
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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_AddPlayerName = new System.Windows.Forms.TextBox();
            this.label_Rank = new System.Windows.Forms.Label();
            this.listBox_Ranks = new System.Windows.Forms.ListBox();
            this.radioButton_TopRung = new System.Windows.Forms.RadioButton();
            this.radioButton_Middle = new System.Windows.Forms.RadioButton();
            this.radioButton_LowerMiddle = new System.Windows.Forms.RadioButton();
            this.radioButton_Bottom = new System.Windows.Forms.RadioButton();
            this.label_LadderRung = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 48);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // textBox_AddPlayerName
            // 
            this.textBox_AddPlayerName.Location = new System.Drawing.Point(56, 45);
            this.textBox_AddPlayerName.MaxLength = 255;
            this.textBox_AddPlayerName.Name = "textBox_AddPlayerName";
            this.textBox_AddPlayerName.Size = new System.Drawing.Size(191, 20);
            this.textBox_AddPlayerName.TabIndex = 1;
            this.textBox_AddPlayerName.TextChanged += new System.EventHandler(this.textBox_AddPlayerName_TextChanged);
            // 
            // label_Rank
            // 
            this.label_Rank.AutoSize = true;
            this.label_Rank.Location = new System.Drawing.Point(14, 72);
            this.label_Rank.Name = "label_Rank";
            this.label_Rank.Size = new System.Drawing.Size(36, 13);
            this.label_Rank.TabIndex = 2;
            this.label_Rank.Text = "Rank:";
            // 
            // listBox_Ranks
            // 
            this.listBox_Ranks.FormattingEnabled = true;
            this.listBox_Ranks.Items.AddRange(new object[] {
            "9 dan",
            "8 dan",
            "7 dan",
            "6 dan",
            "5 dan",
            "4 dan",
            "3 dan",
            "2 dan",
            "1 dan",
            "1 kyu",
            "2 kyu",
            "3 kyu",
            "4 kyu",
            "5 kyu",
            "6 kyu",
            "7 kyu",
            "8 kyu",
            "9 kyu",
            "10 kyu",
            "11 kyu",
            "12 kyu",
            "13 kyu",
            "14 kyu",
            "15 kyu",
            "16 kyu",
            "17 kyu",
            "18 kyu",
            "19 kyu",
            "20 kyu",
            "21 kyu",
            "22 kyu",
            "23 kyu",
            "24 kyu",
            "25 kyu",
            "26 kyu",
            "27 kyu",
            "28 kyu",
            "29 kyu",
            "30 kyu",
            "31 kyu",
            "32 kyu",
            "33 kyu",
            "34 kyu",
            "35 kyu",
            "36 kyu"});
            this.listBox_Ranks.Location = new System.Drawing.Point(58, 72);
            this.listBox_Ranks.Name = "listBox_Ranks";
            this.listBox_Ranks.Size = new System.Drawing.Size(62, 69);
            this.listBox_Ranks.TabIndex = 3;
            this.listBox_Ranks.SelectedIndexChanged += new System.EventHandler(this.listBox_Ranks_SelectedIndexChanged);
            // 
            // radioButton_TopRung
            // 
            this.radioButton_TopRung.AutoSize = true;
            this.radioButton_TopRung.Checked = true;
            this.radioButton_TopRung.Location = new System.Drawing.Point(136, 93);
            this.radioButton_TopRung.Name = "radioButton_TopRung";
            this.radioButton_TopRung.Size = new System.Drawing.Size(44, 17);
            this.radioButton_TopRung.TabIndex = 4;
            this.radioButton_TopRung.TabStop = true;
            this.radioButton_TopRung.Text = "Top";
            this.radioButton_TopRung.UseVisualStyleBackColor = true;
            // 
            // radioButton_Middle
            // 
            this.radioButton_Middle.AutoSize = true;
            this.radioButton_Middle.Location = new System.Drawing.Point(136, 115);
            this.radioButton_Middle.Name = "radioButton_Middle";
            this.radioButton_Middle.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Middle.TabIndex = 5;
            this.radioButton_Middle.Text = "Middle";
            this.radioButton_Middle.UseVisualStyleBackColor = true;
            // 
            // radioButton_LowerMiddle
            // 
            this.radioButton_LowerMiddle.AutoSize = true;
            this.radioButton_LowerMiddle.Location = new System.Drawing.Point(198, 115);
            this.radioButton_LowerMiddle.Name = "radioButton_LowerMiddle";
            this.radioButton_LowerMiddle.Size = new System.Drawing.Size(88, 17);
            this.radioButton_LowerMiddle.TabIndex = 6;
            this.radioButton_LowerMiddle.Text = "Lower Middle";
            this.radioButton_LowerMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bottom
            // 
            this.radioButton_Bottom.AutoSize = true;
            this.radioButton_Bottom.Location = new System.Drawing.Point(198, 92);
            this.radioButton_Bottom.Name = "radioButton_Bottom";
            this.radioButton_Bottom.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Bottom.TabIndex = 7;
            this.radioButton_Bottom.Text = "Bottom";
            this.radioButton_Bottom.UseVisualStyleBackColor = true;
            // 
            // label_LadderRung
            // 
            this.label_LadderRung.AutoSize = true;
            this.label_LadderRung.Location = new System.Drawing.Point(133, 72);
            this.label_LadderRung.Name = "label_LadderRung";
            this.label_LadderRung.Size = new System.Drawing.Size(72, 13);
            this.label_LadderRung.TabIndex = 8;
            this.label_LadderRung.Text = "Ladder Rung:";
            // 
            // button_OK
            // 
            this.button_OK.Enabled = false;
            this.button_OK.Location = new System.Drawing.Point(58, 176);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(153, 176);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // IAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 225);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_LadderRung);
            this.Controls.Add(this.radioButton_Bottom);
            this.Controls.Add(this.radioButton_LowerMiddle);
            this.Controls.Add(this.radioButton_Middle);
            this.Controls.Add(this.radioButton_TopRung);
            this.Controls.Add(this.listBox_Ranks);
            this.Controls.Add(this.label_Rank);
            this.Controls.Add(this.textBox_AddPlayerName);
            this.Controls.Add(this.label_Name);
            this.Name = "IAddPlayer";
            this.Text = "Add New Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_AddPlayerName;
        private System.Windows.Forms.Label label_Rank;
        private System.Windows.Forms.ListBox listBox_Ranks;
        private System.Windows.Forms.RadioButton radioButton_TopRung;
        private System.Windows.Forms.RadioButton radioButton_Middle;
        private System.Windows.Forms.RadioButton radioButton_LowerMiddle;
        private System.Windows.Forms.RadioButton radioButton_Bottom;
        private System.Windows.Forms.Label label_LadderRung;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}