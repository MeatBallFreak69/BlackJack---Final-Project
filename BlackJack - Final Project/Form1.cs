﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack___Final_Project
{
    public partial class frmMainGame : Form
    {
        int money;
        int playerCardValue;
        int EnemyCardValue;
        int cardIndex;
        int moveCardsTick;

        Random shuffle = new Random();

        Bitmap deck = Properties.Resources.betterCards;
        List<Bitmap> cards = new List<Bitmap>();
        List<Bitmap> shuffledDeck = new List<Bitmap>();
        List<int> chips = new List<int>();


        public frmMainGame()
        {
            InitializeComponent();
        }

        private void frmMainGame_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    cards.Add(deck.Clone(new Rectangle(j * 61, i * 81, 39, 56), deck.PixelFormat));
                }
            }
            imgDealHand.Image = Properties.Resources.red_back;
            money = 100;
            lblBank.Text = "$" + Convert.ToString(money);
            if (money % 1 == 0)
            {
                chips.Add(1);
                lstSelectChips.DataSource = chips;
            }
            else if (money % 5 == 0)
            {
                chips.Add(5);
                lstSelectChips.DataSource = chips;
            }
            else if (money % 10 == 0)
            {
                chips.Add(10);
                lstSelectChips.DataSource = chips;
            }
            else if (money % 20 == 0)
            {
                chips.Add(20);
                lstSelectChips.DataSource = chips;
            }
            else if (money % 50 == 0)
            {
                chips.Add(50);
                lstSelectChips.DataSource = chips;
            }
            else if (money % 100 == 0)
            {
                chips.Add(100);
                lstSelectChips.DataSource = chips;
            }
        }

        private void btnTutorials_Click(object sender, EventArgs e)
        {
            frmTutorials formTutorials = new frmTutorials();
            formTutorials.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void tmrAddCards_Tick(object sender, EventArgs e)
        {
            moveCardsTick++;
        }

        private void imgChpPlcDwn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(imgChpPlcDwn, "Place chips here");
        }
    }
}
