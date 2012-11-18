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
        public event EventHandler PAdded;
        public EventArgs ea = null;

        public IAddPlayer()
        {
            InitializeComponent();
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

            if ((textBox_AddPlayerName.Text != "")
                && (listBox_Ranks.SelectedIndex != -1))
            {
                button_OK.Enabled = true;
            }
            else
                button_OK.Enabled = false;
        }

        private void textBox_AddPlayerName_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_AddPlayerName.Text != "")
                && (listBox_Ranks.SelectedIndex != -1))
            {
                button_OK.Enabled = true;
            }
            else
                button_OK.Enabled = false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            PAdded(this, ea);
        }
    }
}
