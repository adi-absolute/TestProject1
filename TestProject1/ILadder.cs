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
    public partial class ILadder : Form
    {
        public Ladder ladder = new Ladder();

        public ILadder()
        {
            InitializeComponent();

            
        }

        private void button_AddGame_Click(object sender, EventArgs e)
        {

        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            IAddPlayer iPlayer = new IAddPlayer();
            iPlayer.PAdded += new EventHandler(iPlayer_PAdded);
            iPlayer.ShowDialog();
            
        }

        void iPlayer_PAdded(object sender, EventArgs e)
        {
            MessageBox.Show("Bow wow!");
            //throw new NotImplementedException();
        }


    }

}
