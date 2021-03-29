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
    public partial class frmTutorials : Form
    {
        public frmTutorials()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStratagies_Click(object sender, EventArgs e)
        {
            frmStrategyGuide formStrategyGuide = new frmStrategyGuide();
            formStrategyGuide.ShowDialog();
        }

        private void btnCardValues_Click(object sender, EventArgs e)
        {
            frmHandValues formHandValues = new frmHandValues();
            formHandValues.ShowDialog();
        }

        private void btnGameInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The goal of blackjack is to beat the dealer's hand without going over 21. Face cards are worth 10. Aces are worth 1 or 11, whichever makes a better hand. Each player starts with two cards, one of the dealer's cards is hidden until the end. To 'Hit' is to ask for another card. To 'Stand' is to hold your total and end your turn. If you go over 21 you bust, and the dealer wins regardless of the dealer's hand. If you are dealt 21 from the start (Ace & 10), you got a blackjack. Blackjack usually means you win 1.5 the amount of your bet. Depends on the casino. Dealer will hit until his/her cards total 17 or higher. Doubling is like a hit, only the bet is doubled and you only get one more card. Split can be done when you have two of the same card - the pair is split into two hands. Splitting also doubles the bet, because each new hand is worth the original bet. You can only double/split on the first move, or first move of a hand created by a split. You cannot play on two aces after they are split. You can double on a hand resulting from a split, tripling or quadrupling you bet.", "Game Tutorial");
        }
    }
}
