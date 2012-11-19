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
    public delegate void EventHandler(object sender, PlayerArgs p);

    public partial class IAddPlayer : Form
    {
        public event EventHandler PlayerAdded;
        public EventArgs ea = null;
        public PlayerArgs pArg = new PlayerArgs();

        public IAddPlayer()
        {
            InitializeComponent();
        }

        private void listBox_Ranks_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton_RungTop.Checked = true;

            if (listBox_Ranks.SelectedIndex < 10)
            {
                radioButton_RungFourth.Enabled = true;
                radioButton_RungThird.Enabled = true;
            }
            else if (listBox_Ranks.SelectedIndex < 28)
            {
                radioButton_RungFourth.Enabled = false;
                radioButton_RungThird.Enabled = true;
            }
            else
            {
                radioButton_RungFourth.Enabled = false;
                radioButton_RungThird.Enabled = false;
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
            pArg.Name = textBox_AddPlayerName.Text;
            pArg.rank = (uint)listBox_Ranks.SelectedIndex;
            if (radioButton_RungTop.Checked == true)
                pArg.rung = 0;
            if (radioButton_RungSecond.Checked == true)
                pArg.rung = 1;
            if (radioButton_RungThird.Checked == true)
                pArg.rung = 2;
            if (radioButton_RungFourth.Checked == true)
                pArg.rung = 3;

            PlayerAdded(this, pArg);

            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class PlayerArgs : EventArgs
    {
        public string Name { get; set; }
        public uint rank { get; set; }
        public uint rung { get; set; }
    }
}
