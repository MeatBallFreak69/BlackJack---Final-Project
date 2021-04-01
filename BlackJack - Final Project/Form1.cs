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
        double money;
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
                imgEnemyCardTwo.Visible = true;      //Checks card values

                checkPlayerCardOne();
                checkPlayerSecondCard();
                checkSecondEnemyCard();
                lblPlayerCardsValue.Text = Convert.ToString(playerCardsValue);
                lblEnemyCardsValue.Text = Convert.ToString(enemyCardsValue);
                btnStand.Enabled = true;
            }
        }
        private void btnStand_Click(object sender, EventArgs e)
        {
            publicCards.Add(imgEnemyCardOne);
            deltHands.Add(shuffledCards[0]);
            shuffledCards.Remove(shuffledCards[0]);

            imgEnemyCardOne.Image = deltHands[3];

            checkFirstEnemyCard();
            lblEnemyCardsValue.Text = Convert.ToString(enemyCardsValue);

            if (enemyCardsValue < 17)
            {
                publicCards.Add(imgEnemyCardThree);
                deltHands.Add(shuffledCards[0]);
                shuffledCards.Remove(shuffledCards[0]);
                imgEnemyCardThree.Visible = true;
                imgEnemyCardThree.Image = deltHands[4];

                checkThirdEnemyCard();
                lblEnemyCardsValue.Text = Convert.ToString(enemyCardsValue);
                if (enemyCardsValue < 17)
                {
                    publicCards.Add(imgEnemyCardFour);
                    deltHands.Add(shuffledCards[0]);
                    shuffledCards.Remove(shuffledCards[0]);
                    imgEnemyCardFour.Visible = true;
                    imgEnemyCardThree.Image = deltHands[5];

                    checkFourthEnemyCard();
                    lblEnemyCardsValue.Text = Convert.ToString(enemyCardsValue);
                }
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

        public void enemyBust()
        {
            MessageBox.Show("Player win, dealer bust!", "You win!");

            enemyCardsValue = 0;
            playerCardsValue = 0;

            for (int i = 0; i < publicCards.Count; i++)
            {
                publicCards.Remove(publicCards[i]);
            }
            imgEnemyCardFour.Image = Properties.Resources.red_back;
            imgEnemyCardThree.Image = Properties.Resources.red_back;
            imgEnemyCardTwo.Image = Properties.Resources.red_back;
            imgEnemyCardOne.Image = Properties.Resources.red_back;
            shuffledCards.Clear();
            deltHands.Clear();

            ShuffleDeck();

            money += betAmount * 1.5;
            lblBank.Text = "$" + Convert.ToString(money);
            betAmount = 0;
        }

        public void checkFourthEnemyCard()
        {
            //Spades
            if (imgEnemyCardFour.Image == cards[0])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardFour.Image == cards[1])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardFour.Image == cards[2])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardFour.Image == cards[3])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardFour.Image == cards[4])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardFour.Image == cards[5])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardFour.Image == cards[6])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardFour.Image == cards[7])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardFour.Image == cards[8])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardFour.Image == cards[9])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[10])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[11])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[12])
            {
                enemyCardsValue += 10;
            }

            //Clubs
            if (imgEnemyCardFour.Image == cards[13])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardFour.Image == cards[14])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardFour.Image == cards[15])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardFour.Image == cards[16])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardFour.Image == cards[17])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardFour.Image == cards[18])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardFour.Image == cards[19])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardFour.Image == cards[20])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardFour.Image == cards[21])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardFour.Image == cards[22])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[23])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[24])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[25])
            {
                enemyCardsValue += 10;
            }

            //Diamonds
            if (imgEnemyCardFour.Image == cards[26])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardFour.Image == cards[27])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardFour.Image == cards[28])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardFour.Image == cards[29])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardFour.Image == cards[30])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardFour.Image == cards[31])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardFour.Image == cards[32])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardFour.Image == cards[33])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardFour.Image == cards[34])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardFour.Image == cards[35])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[36])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[37])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[38])
            {
                enemyCardsValue += 10;
            }

            //Hearts
            if (imgEnemyCardFour.Image == cards[39])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardFour.Image == cards[40])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardFour.Image == cards[41])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardFour.Image == cards[42])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardFour.Image == cards[43])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardFour.Image == cards[44])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardFour.Image == cards[45])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardFour.Image == cards[46])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardFour.Image == cards[47])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardFour.Image == cards[48])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[49])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[50])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardFour.Image == cards[51])
            {
                enemyCardsValue += 10;
            }
        }

        public void checkPlayerSecondCard()
        {
            if (imgPlayerCardTwo.Image == cards[0])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardTwo.Image == cards[1])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardTwo.Image == cards[2])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardTwo.Image == cards[3])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardTwo.Image == cards[4])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardTwo.Image == cards[5])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardTwo.Image == cards[6])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardTwo.Image == cards[7])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardTwo.Image == cards[8])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardTwo.Image == cards[9])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[10])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[11])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[12])
            {
                playerCardsValue += 10;
            }

            //Clubs
            if (imgPlayerCardTwo.Image == cards[13])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardTwo.Image == cards[14])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardTwo.Image == cards[15])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardTwo.Image == cards[16])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardTwo.Image == cards[17])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardTwo.Image == cards[18])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardTwo.Image == cards[19])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardTwo.Image == cards[20])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardTwo.Image == cards[21])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardTwo.Image == cards[22])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[23])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[24])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[25])
            {
                playerCardsValue += 10;
            }

            //Diamonds
            if (imgPlayerCardTwo.Image == cards[26])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardTwo.Image == cards[27])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardTwo.Image == cards[28])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardTwo.Image == cards[29])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardTwo.Image == cards[30])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardTwo.Image == cards[31])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardTwo.Image == cards[32])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardTwo.Image == cards[33])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardTwo.Image == cards[34])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardTwo.Image == cards[35])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[36])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[37])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[38])
            {
                playerCardsValue += 10;
            }

            //Hearts
            if (imgPlayerCardTwo.Image == cards[39])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardTwo.Image == cards[40])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardTwo.Image == cards[41])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardTwo.Image == cards[42])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardTwo.Image == cards[43])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardTwo.Image == cards[44])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardTwo.Image == cards[45])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardTwo.Image == cards[46])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardTwo.Image == cards[47])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardTwo.Image == cards[48])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[49])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[50])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardTwo.Image == cards[51])
            {
                playerCardsValue += 10;
            } 
        }

        public void checkFirstEnemyCard()
        {
            //First enemy card

            //Spades
            if (imgEnemyCardOne.Image == cards[0])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardOne.Image == cards[1])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardOne.Image == cards[2])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardOne.Image == cards[3])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardOne.Image == cards[4])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardOne.Image == cards[5])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardOne.Image == cards[6])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardOne.Image == cards[7])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardOne.Image == cards[8])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardOne.Image == cards[9])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[10])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[11])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[12])
            {
                enemyCardsValue += 10;
            }

            //Clubs
            if (imgEnemyCardOne.Image == cards[13])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardOne.Image == cards[14])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardOne.Image == cards[15])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardOne.Image == cards[16])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardOne.Image == cards[17])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardOne.Image == cards[18])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardOne.Image == cards[19])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardOne.Image == cards[20])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardOne.Image == cards[21])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardOne.Image == cards[22])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[23])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[24])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[25])
            {
                enemyCardsValue += 10;
            }

            //Diamonds
            if (imgEnemyCardOne.Image == cards[26])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardOne.Image == cards[27])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardOne.Image == cards[28])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardOne.Image == cards[29])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardOne.Image == cards[30])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardOne.Image == cards[31])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardOne.Image == cards[32])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardOne.Image == cards[33])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardOne.Image == cards[34])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardOne.Image == cards[35])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[36])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[37])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[38])
            {
                enemyCardsValue += 10;
            }

            //Hearts
            if (imgEnemyCardOne.Image == cards[39])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardOne.Image == cards[40])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardOne.Image == cards[41])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardOne.Image == cards[42])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardOne.Image == cards[43])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardOne.Image == cards[44])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardOne.Image == cards[45])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardOne.Image == cards[46])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardOne.Image == cards[47])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardOne.Image == cards[48])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[49])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[50])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardOne.Image == cards[51])
            {
                enemyCardsValue += 10;
            }
        }

        public void checkSecondEnemyCard()
        {
            //Second enemy card
            //Spades
            if (imgEnemyCardTwo.Image == cards[0])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            if (imgEnemyCardTwo.Image == cards[1])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardTwo.Image == cards[2])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardTwo.Image == cards[3])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardTwo.Image == cards[4])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardTwo.Image == cards[5])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardTwo.Image == cards[6])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardTwo.Image == cards[7])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardTwo.Image == cards[8])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardTwo.Image == cards[9])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[10])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[11])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[12])
            {
                enemyCardsValue += 10;
            }

            //Clubs
            if (imgEnemyCardTwo.Image == cards[13])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardTwo.Image == cards[14])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardTwo.Image == cards[15])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardTwo.Image == cards[16])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardTwo.Image == cards[17])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardTwo.Image == cards[18])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardTwo.Image == cards[19])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardTwo.Image == cards[20])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardTwo.Image == cards[21])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardTwo.Image == cards[22])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[23])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[24])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[25])
            {
                enemyCardsValue += 10;
            }

            //Diamonds 
            if (imgEnemyCardTwo.Image == cards[26])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardTwo.Image == cards[27])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardTwo.Image == cards[28])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardTwo.Image == cards[29])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardTwo.Image == cards[30])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardTwo.Image == cards[31])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardTwo.Image == cards[32])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardTwo.Image == cards[33])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardTwo.Image == cards[34])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardTwo.Image == cards[35])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[36])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[37])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[38])
            {
                enemyCardsValue += 10;
            }

            //Hearts 
            if (imgEnemyCardTwo.Image == cards[39])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardTwo.Image == cards[40])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardTwo.Image == cards[41])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardTwo.Image == cards[42])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardTwo.Image == cards[43])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardTwo.Image == cards[44])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardTwo.Image == cards[45])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardTwo.Image == cards[46])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardTwo.Image == cards[47])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardTwo.Image == cards[48])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[49])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[50])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardTwo.Image == cards[51])
            {
                enemyCardsValue += 10;
            }
        }

        public void checkThirdEnemyCard()
        {
            //First enemy card

            //Spades
            if (imgEnemyCardThree.Image == cards[0])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardThree.Image == cards[1])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardThree.Image == cards[2])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardThree.Image == cards[3])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardThree.Image == cards[4])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardThree.Image == cards[5])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardThree.Image == cards[6])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardThree.Image == cards[7])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardThree.Image == cards[8])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardThree.Image == cards[9])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[10])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[11])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[12])
            {
                enemyCardsValue += 10;
            }

            //Clubs
            if (imgEnemyCardThree.Image == cards[13])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardThree.Image == cards[14])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardThree.Image == cards[15])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardThree.Image == cards[16])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardThree.Image == cards[17])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardThree.Image == cards[18])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardThree.Image == cards[19])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardThree.Image == cards[20])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardThree.Image == cards[21])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardThree.Image == cards[22])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[23])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[24])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[25])
            {
                enemyCardsValue += 10;
            }

            //Diamonds
            if (imgEnemyCardThree.Image == cards[26])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardThree.Image == cards[27])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardThree.Image == cards[28])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardThree.Image == cards[29])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardThree.Image == cards[30])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardThree.Image == cards[31])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardThree.Image == cards[32])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardThree.Image == cards[33])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardThree.Image == cards[34])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardThree.Image == cards[35])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[36])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[37])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[38])
            {
                enemyCardsValue += 10;
            }

            //Hearts
            if (imgEnemyCardThree.Image == cards[39])
            {
                if (enemyCardsValue <= 10)
                {
                    enemyCardsValue += 10;
                }
                else
                {
                    enemyCardsValue += 1;
                }
            }
            else if (imgEnemyCardThree.Image == cards[40])
            {
                enemyCardsValue += 2;
            }
            else if (imgEnemyCardThree.Image == cards[41])
            {
                enemyCardsValue += 3;
            }
            else if (imgEnemyCardThree.Image == cards[42])
            {
                enemyCardsValue += 4;
            }
            else if (imgEnemyCardThree.Image == cards[43])
            {
                enemyCardsValue += 5;
            }
            else if (imgEnemyCardThree.Image == cards[44])
            {
                enemyCardsValue += 6;
            }
            else if (imgEnemyCardThree.Image == cards[45])
            {
                enemyCardsValue += 7;
            }
            else if (imgEnemyCardThree.Image == cards[46])
            {
                enemyCardsValue += 8;
            }
            else if (imgEnemyCardThree.Image == cards[47])
            {
                enemyCardsValue += 9;
            }
            else if (imgEnemyCardThree.Image == cards[48])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[49])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[50])
            {
                enemyCardsValue += 10;
            }
            else if (imgEnemyCardThree.Image == cards[51])
            {
                enemyCardsValue += 10;
            }
        }

        public void checkPlayerCardOne()
        {  
            //First player card
            //Spades
            if (imgPlayerCardOne.Image == cards[0])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardOne.Image == cards[1])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardOne.Image == cards[2])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardOne.Image == cards[3])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardOne.Image == cards[4])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardOne.Image == cards[5])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardOne.Image == cards[6])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardOne.Image == cards[7])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardOne.Image == cards[8])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardOne.Image == cards[9])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[10])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[11])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[12])
            {
                playerCardsValue += 10;
            }

            //Clubs
            if (imgPlayerCardOne.Image == cards[13])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardOne.Image == cards[14])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardOne.Image == cards[15])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardOne.Image == cards[16])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardOne.Image == cards[17])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardOne.Image == cards[18])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardOne.Image == cards[19])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardOne.Image == cards[20])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardOne.Image == cards[21])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardOne.Image == cards[22])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[23])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[24])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[25])
            {
                playerCardsValue += 10;
            }

            //Diamonds
            if (imgPlayerCardOne.Image == cards[26])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardOne.Image == cards[27])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardOne.Image == cards[28])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardOne.Image == cards[29])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardOne.Image == cards[30])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardOne.Image == cards[31])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardOne.Image == cards[32])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardOne.Image == cards[33])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardOne.Image == cards[34])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardOne.Image == cards[35])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[36])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[37])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[38])
            {
                playerCardsValue += 10;
            }

            //Hearts
            if (imgPlayerCardOne.Image == cards[39])
            {
                if (playerCardsValue <= 10)
                {
                    playerCardsValue += 10;
                }
                else
                {
                    playerCardsValue += 1;
                }
            }
            else if (imgPlayerCardOne.Image == cards[40])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardOne.Image == cards[41])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardOne.Image == cards[42])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardOne.Image == cards[43])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardOne.Image == cards[44])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardOne.Image == cards[45])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardOne.Image == cards[46])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardOne.Image == cards[47])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardOne.Image == cards[48])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[49])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[50])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardOne.Image == cards[51])
            {
                playerCardsValue += 10;
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enemyBust();
        }
    }
}
