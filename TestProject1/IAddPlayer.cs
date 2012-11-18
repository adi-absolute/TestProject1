using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class IAddPlayer : Form
    {
        bool okPressed = false;
        public IAddPlayer()
        {
            InitializeComponent();
            textBox_AddPlayerName.Text = listBox_Ranks.SelectedIndex.ToString();
            while (okPressed == false)
            {
                if ((textBox_AddPlayerName.Text != null)
                && (listBox_Ranks.SelectedIndex != -1))
                {
                    button_OK.Enabled = true;
                }
                else
                {
                    button_OK.Enabled = false;
                }
            }

        }

        private void listBox_Ranks_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton_TopRung.Checked = true;

            if (listBox_Ranks.SelectedIndex < 10)
            {
                radioButton_LowerMiddle.Enabled = true;
                radioButton_Middle.Enabled = true;
            }
            else if (listBox_Ranks.SelectedIndex < 28)
            {
                radioButton_LowerMiddle.Enabled = false;
                radioButton_Middle.Enabled = true;
            }
            else
            {
                radioButton_LowerMiddle.Enabled = false;
                radioButton_Middle.Enabled = false;
            }
        }
    }
}
