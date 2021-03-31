using System;
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
        int betAmount = 0;

        PictureBox selectedChip;

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
            tltChipPlacement.SetToolTip(imgChpPlcDwn, "Place chips here");
        }

        private void imgOneChip_MouseHover(object sender, EventArgs e)
        {
            tltOneChip.SetToolTip(imgOneChip, "Value: $1");
        }

        private void imgFiveChip_MouseHover(object sender, EventArgs e)
        {
            tltFiveChip.SetToolTip(imgFiveChip, "Value: $5");
        }

        private void imgTenChip_MouseHover(object sender, EventArgs e)
        {
            tltTenChip.SetToolTip(imgTenChip, "Value: $10");
        }

        private void imgTwentyChip_MouseHover(object sender, EventArgs e)
        {
            tltTwentyChip.SetToolTip(imgTwentyChip, "Value: $20");
        }

        private void imgFiftyChip_MouseHover(object sender, EventArgs e)
        {
            tltFiftyChip.SetToolTip(imgFiftyChip, "Value: $50");
        }

        private void imgHundredChip_MouseHover(object sender, EventArgs e)
        {
            tltHundredChip.SetToolTip(imgHundredChip, "Value: $100");
        }

        private void tmrChipFollowMouse_Tick(object sender, EventArgs e)
        {
            selectedChip.Left = MousePosition.X - selectedChip.Width;
            selectedChip.Top = MousePosition.Y - selectedChip.Height;
        }

        private void imgOneChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 1;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 1;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }

        private void imgFiveChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 5;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 5;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }

        private void imgTenChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 10;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 10;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }

        private void imgTwentyChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 20;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 20;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }

        private void imgFiftyChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 50;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 50;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }

        private void imgHundredChip_MouseDown(object sender, MouseEventArgs e)
        {
            betAmount += 100;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= 100;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }
        }
    }
}
