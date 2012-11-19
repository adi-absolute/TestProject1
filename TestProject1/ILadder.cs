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
            iPlayer.PlayerAdded += new EventHandler(iPlayer_onPlayerAdded);
            iPlayer.ShowDialog();
            
        }

        void iPlayer_onPlayerAdded(object sender, PlayerArgs e)
        {
            string name = e.Name;
            eRankNumber rank = (eRankNumber)e.rank;
            eRungPosition rung = (eRungPosition)e.rung;
            //Player p = new Player(name, rank, rung);
            ladder.AddPlayer(name, rank, rung);
            MessageBox.Show("Player Successfully Added");
            //throw new NotImplementedException();
        }


    }

}
