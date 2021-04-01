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
        public static int betAmount = 0;
        int turnCounter = 0;
        int increaseBy = 0;

        Bitmap deck = Properties.Resources.betterCards;

        public static List<Bitmap> cards = new List<Bitmap>();
        public static List<Bitmap> shuffledCards = new List<Bitmap>();
        List<Bitmap> deltHands = new List<Bitmap>();
        List<PictureBox> publicCards = new List<PictureBox>();



        public frmMainGame()
        {
            InitializeComponent();
        }

        private void frmMainGame_Load(object sender, EventArgs e)
        {
            CreateDeck();
            ShuffleDeck();

            shuffledCards.Clear();
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
            CheckBet(1);
        }

        private void imgFiveChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(5);
        }

        private void imgTenChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(10);
        }

        private void imgTwentyChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(20);
        }

        private void imgFiftyChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(50);
        }

        private void imgHundredChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(100);
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

                //Removes cards from shuffled card list and adds it to cards delt
                for (int i = 0; i < publicCards.Count; i++)
                {
                    deltHands.Add(shuffledCards[i]);
                    shuffledCards.Remove(shuffledCards[i]);
                }

                //Updates card iamges with the cards from the list deltHands
                imgPlayerCardOne.Image = deltHands[0];
                imgPlayerCardTwo.Image = deltHands[1];
                imgEnemyCardTwo.Image = deltHands[2];

                //Disables buttons
                btnResetBet.Enabled = false;
                btnDeal.Enabled = false;

                //Makes cards 'playerCardOne', 'playerCardTwo', 'enemyCardOne', 'enemyCardTwo' visible
                imgPlayerCardOne.Visible = true;
                imgPlayerCardTwo.Visible = true;
                imgEnemyCardOne.Visible = true;
                imgEnemyCardTwo.Visible = true;
            }
        }
        public void ShuffleDeck()
        {
            shuffledCards.Clear();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledCards.Add(cards[i]);
            }
        }
        
        public void CreateDeck()
        {
            //Seperates each image from spritesheet and adds to a list
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    cards.Add(deck.Clone(new Rectangle(j * 61, i * 81, 39, 56), deck.PixelFormat));
                }
            }
        }

        public void dealVisible()
        {
            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        public void CheckBet(int increaseBy)
        {
            //Adds bet and checks to see if you have enough to bet
            betAmount += increaseBy;
            if (betAmount <= money)
            {
                lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            }
            else
            {
                betAmount -= increaseBy;
                MessageBox.Show("Sorry, you're too poor to bet this much", "Broke!");
            }

            dealVisible();
        }
    }
}
