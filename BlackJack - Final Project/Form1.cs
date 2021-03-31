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
        int betAmount = 0;
        int turnCounter = 0;

        Bitmap deck = Properties.Resources.betterCards;
        List<Bitmap> cards = new List<Bitmap>();
        List<Bitmap> shuffledCards = new List<Bitmap>();
        List<Bitmap> deltHands = new List<Bitmap>();
        List<PictureBox> publicCards = new List<PictureBox>();



        public frmMainGame()
        {
            InitializeComponent();
        }

        private void frmMainGame_Load(object sender, EventArgs e)
        {
            //Seperates each image from spritesheet and adds to a list
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    cards.Add(deck.Clone(new Rectangle(j * 61, i * 81, 39, 56), deck.PixelFormat));
                }
            }

            for (int i = 0; i < cards.Count; i++)
            {
                shuffledCards.Add(cards[i]);
            }
           

            imgDealHand.Image = Properties.Resources.red_back;
            money = 100;
            lblBank.Text = "$" + Convert.ToString(money);
            betAmount = 0;
            lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
        }
        
        private void btnTutorials_Click(object sender, EventArgs e)
        {
            frmTutorials formTutorials = new frmTutorials();
            formTutorials.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Quits form
            this.Close();
        }

        private void tmrAddCards_Tick(object sender, EventArgs e)
        {

        }

        private void imgOneChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltOneChip.SetToolTip(imgOneChip, "Value: $1");
        }

        private void imgFiveChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltFiveChip.SetToolTip(imgFiveChip, "Value: $5");
        }

        private void imgTenChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltTenChip.SetToolTip(imgTenChip, "Value: $10");
        }

        private void imgTwentyChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltTwentyChip.SetToolTip(imgTwentyChip, "Value: $20");
        }

        private void imgFiftyChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltFiftyChip.SetToolTip(imgFiftyChip, "Value: $50");
        }

        private void imgHundredChip_MouseHover(object sender, EventArgs e)
        {
            //Tooltip
            tltHundredChip.SetToolTip(imgHundredChip, "Value: $100");
        }

        private void imgOneChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void imgFiveChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void imgTenChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void imgTwentyChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void imgFiftyChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void imgHundredChip_MouseDown(object sender, MouseEventArgs e)
        {
            //Adds bet and checks to see if you have enough to bet
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        private void btnResetBet_Click(object sender, EventArgs e)
        {
            betAmount = 0;
            lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            btnDeal.Visible = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            turnCounter++;
            if (turnCounter == 1)
            {
                //Shuffles Cards
                shuffledCards = shuffledCards.OrderBy(a => Guid.NewGuid()).ToList();

                //Adds visible cards to list
                publicCards.Add(imgPlayerCardOne);
                publicCards.Add(imgPlayerCardTwo);
                publicCards.Add(imgEnemyCardTwo);
                listBox1.DataSource = shuffledCards;


                //Creates random index

                label1.Text = Convert.ToString(shuffledCards.Count);
                
                for (int i = 0; i < publicCards.Count;)
                {
                    deltHands.Add(shuffledCards[shuffledCards.Count]);
                    shuffledCards.Remove(shuffledCards[shuffledCards.Count]);
                }

                imgPlayerCardOne.Image = deltHands[0];

                listBox1.DataSource = deltHands;
                btnResetBet.Enabled = false;
                btnDeal.Enabled = false;
                imgPlayerCardOne.Visible = true;
            }
        }
    }
}
