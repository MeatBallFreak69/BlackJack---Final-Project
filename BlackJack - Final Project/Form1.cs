using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BlackJack___Final_Project
{
    public partial class frmMainGame : Form
    {
        double money;
        public static int betAmount = 0;
        int playerCardsValue = 0;
        int enemyCardsValue = 0;
        int cardTick = 0;

        SoundPlayer randomSound;
        
        Bitmap deck = Properties.Resources.betterCards;

        List<Bitmap> cards = new List<Bitmap>();
        List<Bitmap> shuffledCards = new List<Bitmap>();
        List<SoundPlayer> chipSounds = new List<SoundPlayer>();
        List<Bitmap> deltHands = new List<Bitmap>();
        List<PictureBox> publicCards = new List<PictureBox>();

        Random ranChip = new Random();

        SoundPlayer chips1;
        SoundPlayer chips2;
        SoundPlayer chips3;
        SoundPlayer chips4;
        SoundPlayer chips5;
        SoundPlayer chips6;
        SoundPlayer chips7;
        SoundPlayer chips8;
        SoundPlayer chips9;
        SoundPlayer chips10;
        SoundPlayer chips11;
        SoundPlayer chips12;
        SoundPlayer chips13;
        SoundPlayer chips14;

        public frmMainGame()
        {
            InitializeComponent();
        }

        private void frmMainGame_Load(object sender, EventArgs e)
        {
            

            CreateDeck();
            ShuffleDeck();

            chips1 = new SoundPlayer(Properties.Resources.Chips1);
            chips2 = new SoundPlayer(Properties.Resources.Chips2);
            chips3 = new SoundPlayer(Properties.Resources.Chips3);
            chips4 = new SoundPlayer(Properties.Resources.Chips4);
            chips5 = new SoundPlayer(Properties.Resources.Chips5);
            chips6 = new SoundPlayer(Properties.Resources.Chips6);
            chips7 = new SoundPlayer(Properties.Resources.Chips7);
            chips8 = new SoundPlayer(Properties.Resources.Chips8);
            chips9 = new SoundPlayer(Properties.Resources.Chips9);
            chips10 = new SoundPlayer(Properties.Resources.Chips10);
            chips11 = new SoundPlayer(Properties.Resources.Chips11);
            chips12 = new SoundPlayer(Properties.Resources.Chips12);
            chips13 = new SoundPlayer(Properties.Resources.Chips13);
            chips14 = new SoundPlayer(Properties.Resources.Chips14);

            chipSounds.Add(chips1);
            chipSounds.Add(chips2);
            chipSounds.Add(chips3);
            chipSounds.Add(chips4);
            chipSounds.Add(chips5);
            chipSounds.Add(chips6);
            chipSounds.Add(chips7);
            chipSounds.Add(chips8);
            chipSounds.Add(chips9);
            chipSounds.Add(chips10);
            chipSounds.Add(chips11);
            chipSounds.Add(chips12);
            chipSounds.Add(chips13);
            chipSounds.Add(chips14);

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
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void imgFiveChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(5);
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void imgTenChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(10);
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void imgTwentyChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(20);
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void imgFiftyChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(50);
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void imgHundredChip_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBet(100);
            randomSound = chipSounds[ranChip.Next(0, chipSounds.Count - 1)];
            randomSound.Play();
        }

        private void btnResetBet_Click(object sender, EventArgs e)
        {
            betAmount = 0;
            lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
            btnDeal.Enabled = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            tmrAddCards.Start();
            imgOneChip.Enabled = false;
            imgFiveChip.Enabled = false;
            imgTenChip.Enabled = false;
            imgTwentyChip.Enabled = false;
            imgFiftyChip.Enabled = false;
            imgHundredChip.Enabled = false;

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
                lblPlayerCardsValue.Text = Convert.ToString("Player Card Value: " + playerCardsValue);
                lblEnemyCardsValue.Text = Convert.ToString("Computer Card Value: " + enemyCardsValue);
                btnStand.Enabled = true;
                btnHit.Enabled = true;

            if (playerCardsValue == 21)
            {
                MessageBox.Show("Blackjack! Payout 1:1");

                resetGame();

                money += betAmount;
            }
            
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
                publicCards.Add(imgPlayerCardThree);
                deltHands.Add(shuffledCards[0]);
                shuffledCards.Remove(shuffledCards[0]);
                imgPlayerCardThree.Visible = true;
                imgPlayerCardThree.Image = deltHands[deltHands.Count - 1];

                checkPlayerCardThree();
                lblPlayerCardsValue.Text = Convert.ToString("Player Card Value: " + playerCardsValue);

            if (playerCardsValue > 21)
            {
                playerBust();
            }

            if (playerCardsValue == 21)
            {
                MessageBox.Show("Player win! Payout 2:3", "You win!");

                resetGame();

                money += betAmount * 1.5;
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            publicCards.Add(imgEnemyCardOne);
            deltHands.Add(shuffledCards[0]);
            shuffledCards.Remove(shuffledCards[0]);

            imgEnemyCardOne.Image = deltHands[deltHands.Count - 1];

            checkFirstEnemyCard();
            lblEnemyCardsValue.Text = Convert.ToString("Computer Card Value: " + enemyCardsValue);

            if (enemyCardsValue < 17)
            {
                publicCards.Add(imgEnemyCardThree);
                deltHands.Add(shuffledCards[0]);
                shuffledCards.Remove(shuffledCards[0]);
                imgEnemyCardThree.Visible = true;
                imgEnemyCardThree.Image = deltHands[deltHands.Count - 1];

                checkThirdEnemyCard();
                lblEnemyCardsValue.Text = Convert.ToString("Computer Card Value: " + enemyCardsValue);
            }
            if (enemyCardsValue < 17)
            {
                publicCards.Add(imgEnemyCardFour);
                deltHands.Add(shuffledCards[0]);
                shuffledCards.Remove(shuffledCards[0]);
                imgEnemyCardFour.Visible = true;
                imgEnemyCardThree.Image = deltHands[deltHands.Count - 1];

                checkFourthEnemyCard();
                lblEnemyCardsValue.Text = Convert.ToString("Computer Card Value: " + enemyCardsValue);
            }
            if (enemyCardsValue > 21)
            {
                enemyBust();
            }

            if (enemyCardsValue < 22 && enemyCardsValue > playerCardsValue)
            {
                enemyNonBustWin();
            }
            else if (playerCardsValue < 22 && playerCardsValue > enemyCardsValue)
            {
                playerNonBustWin();
            }
            if (playerCardsValue == enemyCardsValue)
            {
                resetGame();
            }
        }

        public void ShuffleDeck()
        {
            shuffledCards.Clear();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledCards.Add(cards[i]);
            }
            shuffledCards = shuffledCards.OrderBy(a => Guid.NewGuid()).ToList();
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
                btnDeal.Enabled = true;
            }
        }

        public void resetGame()
        {
            imgPlayerCardOne.Location = new Point(688, 12);
            imgPlayerCardTwo.Location = new Point(688, 12);
            imgPlayerCardThree.Location = new Point(688, 12);
            imgEnemyCardOne.Location = new Point(688, 12);
            imgEnemyCardTwo.Location = new Point(688, 12);
            imgEnemyCardThree.Location = new Point(688, 12);
            imgEnemyCardFour.Location = new Point(688, 12);
            tmrAddCards.Stop();
            enemyCardsValue = 0;
            playerCardsValue = 0;


            foreach (PictureBox Image in publicCards)
            {
                Image.Image = Properties.Resources.red_back;
            }

            publicCards.Clear();
            shuffledCards.Clear();
            deltHands.Clear();

            imgPlayerCardThree.Visible = false;
            imgEnemyCardThree.Visible = false;
            imgEnemyCardFour.Visible = false;

            ShuffleDeck();

            btnHit.Enabled = false;
            btnStand.Enabled = false;

            imgOneChip.Enabled = true;
            imgFiveChip.Enabled = true;
            imgTenChip.Enabled = true;
            imgTwentyChip.Enabled = true;
            imgFiftyChip.Enabled = true;
            imgHundredChip.Enabled = true;

            lblBank.Text = "$" + Convert.ToString(money);
            lblPlayerCardsValue.Text = Convert.ToString("Player Card Value: " + playerCardsValue);
            lblEnemyCardsValue.Text = Convert.ToString("Computer Card Value: " + enemyCardsValue);
            betAmount = 0;
            lblBet.Text = $"Bet Amount: ${Convert.ToString(betAmount)}";
        }

        public void playerBust()
        {
            MessageBox.Show("Dealer won, player bust!", "You lose!");

            money -= betAmount;

            resetGame();
        }

        public void enemyBust()
        {
            MessageBox.Show("Player win, dealer bust! Payout 2:3", "You win!");

            money += betAmount * 1.5;
            

            resetGame();
        }

        public void playerNonBustWin()
        {
            MessageBox.Show("Player win! Payout 2:3", "You win!");

            money += betAmount * 1.5;


            resetGame();
        }

        public void enemyNonBustWin()
        {
            MessageBox.Show("Dealer win!", "You lose!");

            money -= betAmount;


            resetGame();
        }

        private void tmrAddCards_Tick(object sender, EventArgs e)
        {
            cardTick++;
            //btnHit.Enabled = false;
            //btnStand.Enabled = false;
            addCardsPreset(imgEnemyCardOne, 256, 12);

            if (publicCards.Count == 3)
            {
                addCardsPreset(imgPlayerCardOne, 256, 268 );
                addCardsPreset(imgPlayerCardTwo, 342, 268);
                addCardsPreset(imgEnemyCardTwo, 342, 12);
            }
            if (publicCards[publicCards.Count - 1] == imgPlayerCardThree)
            {
                addCardsPreset(imgPlayerCardThree, 426, 268);
            }
            if (publicCards[publicCards.Count - 1] == imgEnemyCardOne)
            {
                addCardsPreset(imgPlayerCardOne, 260, 12);
            }
            if (publicCards[publicCards.Count - 1] == imgEnemyCardThree)
            {
                addCardsPreset(imgEnemyCardThree, 426, 12);
            }
        }

        public void addCardsPreset(PictureBox cardType, int X, int Y)
        {
            if (cardType.Location.X != X)
            {
                cardType.Left -= 2;
            }
            else
            {
                if (cardType.Location.Y != Y)
                {
                    cardType.Top += 2;
                    
                }
            }
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

        public void checkPlayerCardThree()
        {
            //Spades
            if (imgPlayerCardThree.Image == cards[0])
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
            else if (imgPlayerCardThree.Image == cards[1])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardThree.Image == cards[2])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardThree.Image == cards[3])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardThree.Image == cards[4])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardThree.Image == cards[5])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardThree.Image == cards[6])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardThree.Image == cards[7])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardThree.Image == cards[8])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardThree.Image == cards[9])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[10])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[11])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[12])
            {
                playerCardsValue += 10;
            }

            //Clubs
            if (imgPlayerCardThree.Image == cards[13])
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
            else if (imgPlayerCardThree.Image == cards[14])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardThree.Image == cards[15])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardThree.Image == cards[16])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardThree.Image == cards[17])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardThree.Image == cards[18])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardThree.Image == cards[19])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardThree.Image == cards[20])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardThree.Image == cards[21])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardThree.Image == cards[22])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[23])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[24])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[25])
            {
                playerCardsValue += 10;
            }

            //Diamonds
            if (imgPlayerCardThree.Image == cards[26])
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
            else if (imgPlayerCardThree.Image == cards[27])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardThree.Image == cards[28])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardThree.Image == cards[29])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardThree.Image == cards[30])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardThree.Image == cards[31])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardThree.Image == cards[32])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardThree.Image == cards[33])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardThree.Image == cards[34])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardThree.Image == cards[35])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[36])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[37])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[38])
            {
                playerCardsValue += 10;
            }

            //Hearts
            if (imgPlayerCardThree.Image == cards[39])
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
            else if (imgPlayerCardThree.Image == cards[40])
            {
                playerCardsValue += 2;
            }
            else if (imgPlayerCardThree.Image == cards[41])
            {
                playerCardsValue += 3;
            }
            else if (imgPlayerCardThree.Image == cards[42])
            {
                playerCardsValue += 4;
            }
            else if (imgPlayerCardThree.Image == cards[43])
            {
                playerCardsValue += 5;
            }
            else if (imgPlayerCardThree.Image == cards[44])
            {
                playerCardsValue += 6;
            }
            else if (imgPlayerCardThree.Image == cards[45])
            {
                playerCardsValue += 7;
            }
            else if (imgPlayerCardThree.Image == cards[46])
            {
                playerCardsValue += 8;
            }
            else if (imgPlayerCardThree.Image == cards[47])
            {
                playerCardsValue += 9;
            }
            else if (imgPlayerCardThree.Image == cards[48])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[49])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[50])
            {
                playerCardsValue += 10;
            }
            else if (imgPlayerCardThree.Image == cards[51])
            {
                playerCardsValue += 10;
            }
        }
    }
}
