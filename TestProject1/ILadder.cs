﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

namespace Project1
{
    public partial class ILadder : Form
    {
        public static string[] rankMap = 
        {   "9 dan", "8 dan", "7 dan", "6 dan", "5 dan", "4 dan",
            "3 dan", "2 dan", "1 dan", "1 kyu", "2 kyu", "3 kyu",
            "4 kyu", "5 kyu", "6 kyu", "7 kyu", "8 kyu", "9 kyu",
            "10 kyu", "11 kyu", "12 kyu", "13 kyu", "14 kyu", "15 kyu",
            "16 kyu", "17 kyu", "18 kyu", "19 kyu", "20 kyu", "21 kyu",
            "22 kyu", "23 kyu", "24 kyu", "25 kyu", "26 kyu", "27 kyu",
            "28 kyu", "29 kyu", "30 kyu", "31 kyu", "32 kyu", "33 kyu",
            "34 kyu", "35 kyu", "36 kyu",  
        };

        public static string[] rungMap = 
        {
            "Top Rung", "Second Rung", "Third Rung", "Fourth Rung"
        };

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
            ladder.AddPlayer(name, rank, rung);
            PopulatePlayerListBox();

            /*
            DataContractSerializer d = new DataContractSerializer(ladder.GetType());
            FileStream writer = new FileStream("dcsFile.gls", FileMode.Create);
            
            d.WriteObject(writer, ladder);
            writer.Close();
            */
        }

        void PopulatePlayerListBox()
        {
            listBox_PlayerList.Items.Clear();
            List<Player> listP = ladder.get_PlayerList();

            for (int i = 0; i < ladder.get_NumberOfPlayers(); i++ )
            {
                listBox_PlayerList.Items.Add(listP[i].myName 
                    + " ("
                    + rankMap[(int)listP[i].GetRankNumber()] 
                    + ")");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }

}
