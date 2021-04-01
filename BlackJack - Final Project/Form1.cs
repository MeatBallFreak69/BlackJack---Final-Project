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
        int playerCardsValue = 0;
        int enemyCardsValue = 0;


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
            imgOneChip.Enabled = false;
            imgFiveChip.Enabled = false;
            imgTenChip.Enabled = false;
            imgTwentyChip.Enabled = false;
            imgFiftyChip.Enabled = false;
            imgHundredChip.Enabled = false;

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

                //Checks card values
                cardValues();
                lblPlayerCardsValue.Text = Convert.ToString(playerCardsValue);
                lblEnemyCardsValue.Text = Convert.ToString(enemyCardsValue);
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

            //Reveals deal button
            if (betAmount > 0)
            {
                btnDeal.Visible = true;
            }
        }

        public void cardValuesPreset(PictureBox player, int index, int playerTypeValue, int valueIncreaseBy)
        {
            if (player.Image == cards[index])
            {
                playerTypeValue += valueIncreaseBy;
            }
            
        }

        public void cardValues()
        {
            //First player card
                cardValuesPreset(imgPlayerCardOne, 2, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardOne, 3, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardOne, 4, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardOne, 5, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardOne, 6, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardOne, 7, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardOne, 8, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardOne, 9, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 10, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 11, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 12, playerCardsValue, 10); 
            

                cardValuesPreset(imgPlayerCardOne, 14, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardOne, 15, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardOne, 16, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardOne, 17, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardOne, 18, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardOne, 19, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardOne, 20, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardOne, 21, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardOne, 22, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 23, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 24, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 25, playerCardsValue, 10);


                cardValuesPreset(imgPlayerCardOne, 27, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardOne, 28, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardOne, 29, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardOne, 30, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardOne, 31, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardOne, 32, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardOne, 33, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardOne, 34, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardOne, 35, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 36, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 37, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 38, playerCardsValue, 10);


                cardValuesPreset(imgPlayerCardOne, 40, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardOne, 41, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardOne, 42, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardOne, 43, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardOne, 44, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardOne, 45, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardOne, 46, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardOne, 47, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardOne, 48, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 49, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 50, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardOne, 51, playerCardsValue, 10);


            //Second player card
                cardValuesPreset(imgPlayerCardTwo, 1, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardTwo, 2, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardTwo, 3, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardTwo, 4, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardTwo, 5, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardTwo, 6, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardTwo, 7, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardTwo, 8, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardTwo, 9, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 10, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 11, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 12, playerCardsValue, 10);


                cardValuesPreset(imgPlayerCardTwo, 14, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardTwo, 15, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardTwo, 16, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardTwo, 17, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardTwo, 18, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardTwo, 19, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardTwo, 20, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardTwo, 21, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardTwo, 22, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 23, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 24, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 25, playerCardsValue, 10);


                cardValuesPreset(imgPlayerCardTwo, 27, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardTwo, 28, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardTwo, 29, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardTwo, 30, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardTwo, 31, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardTwo, 32, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardTwo, 33, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardTwo, 34, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardTwo, 35, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 36, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 37, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 38, playerCardsValue, 10);


                cardValuesPreset(imgPlayerCardTwo, 40, playerCardsValue, 2);
                cardValuesPreset(imgPlayerCardTwo, 41, playerCardsValue, 3);
                cardValuesPreset(imgPlayerCardTwo, 42, playerCardsValue, 4);
                cardValuesPreset(imgPlayerCardTwo, 43, playerCardsValue, 5);
                cardValuesPreset(imgPlayerCardTwo, 44, playerCardsValue, 6);
                cardValuesPreset(imgPlayerCardTwo, 45, playerCardsValue, 7);
                cardValuesPreset(imgPlayerCardTwo, 46, playerCardsValue, 8);
                cardValuesPreset(imgPlayerCardTwo, 47, playerCardsValue, 9);
                cardValuesPreset(imgPlayerCardTwo, 48, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 49, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 50, playerCardsValue, 10);
                cardValuesPreset(imgPlayerCardTwo, 51, playerCardsValue, 10);


            //Second enemy card
                cardValuesPreset(imgEnemyCardTwo, 1, enemyCardsValue, 2);
                cardValuesPreset(imgEnemyCardTwo, 2, enemyCardsValue, 3);
                cardValuesPreset(imgEnemyCardTwo, 3, enemyCardsValue, 4);
                cardValuesPreset(imgEnemyCardTwo, 4, enemyCardsValue, 5);
                cardValuesPreset(imgEnemyCardTwo, 5, enemyCardsValue, 6);
                cardValuesPreset(imgEnemyCardTwo, 6, enemyCardsValue, 7);
                cardValuesPreset(imgEnemyCardTwo, 7, enemyCardsValue, 8);
                cardValuesPreset(imgEnemyCardTwo, 8, enemyCardsValue, 9);
                cardValuesPreset(imgEnemyCardTwo, 9, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 10, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 11, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 12, enemyCardsValue, 10);


                cardValuesPreset(imgEnemyCardTwo, 14, enemyCardsValue, 2);
                cardValuesPreset(imgEnemyCardTwo, 15, enemyCardsValue, 3);
                cardValuesPreset(imgEnemyCardTwo, 16, enemyCardsValue, 4);
                cardValuesPreset(imgEnemyCardTwo, 17, enemyCardsValue, 5);
                cardValuesPreset(imgEnemyCardTwo, 18, enemyCardsValue, 6);
                cardValuesPreset(imgEnemyCardTwo, 19, enemyCardsValue, 7);
                cardValuesPreset(imgEnemyCardTwo, 20, enemyCardsValue, 8);
                cardValuesPreset(imgEnemyCardTwo, 21, enemyCardsValue, 9);
                cardValuesPreset(imgEnemyCardTwo, 22, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 23, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 24, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 25, enemyCardsValue, 10);


                cardValuesPreset(imgEnemyCardTwo, 27, enemyCardsValue, 2);
                cardValuesPreset(imgEnemyCardTwo, 28, enemyCardsValue, 3);
                cardValuesPreset(imgEnemyCardTwo, 29, enemyCardsValue, 4);
                cardValuesPreset(imgEnemyCardTwo, 30, enemyCardsValue, 5);
                cardValuesPreset(imgEnemyCardTwo, 31, enemyCardsValue, 6);
                cardValuesPreset(imgEnemyCardTwo, 32, enemyCardsValue, 7);
                cardValuesPreset(imgEnemyCardTwo, 33, enemyCardsValue, 8);
                cardValuesPreset(imgEnemyCardTwo, 34, enemyCardsValue, 9);
                cardValuesPreset(imgEnemyCardTwo, 35, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 36, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 37, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 38, enemyCardsValue, 10);


                cardValuesPreset(imgEnemyCardTwo, 40, enemyCardsValue, 2);
                cardValuesPreset(imgEnemyCardTwo, 41, enemyCardsValue, 3);
                cardValuesPreset(imgEnemyCardTwo, 42, enemyCardsValue, 4);
                cardValuesPreset(imgEnemyCardTwo, 43, enemyCardsValue, 5);
                cardValuesPreset(imgEnemyCardTwo, 44, enemyCardsValue, 6);
                cardValuesPreset(imgEnemyCardTwo, 45, enemyCardsValue, 7);
                cardValuesPreset(imgEnemyCardTwo, 46, enemyCardsValue, 8);
                cardValuesPreset(imgEnemyCardTwo, 47, enemyCardsValue, 9);
                cardValuesPreset(imgEnemyCardTwo, 48, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 49, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 50, enemyCardsValue, 10);
                cardValuesPreset(imgEnemyCardTwo, 51, enemyCardsValue, 10); 
        }
    }
}
