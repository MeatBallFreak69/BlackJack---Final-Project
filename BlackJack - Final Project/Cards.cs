using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack___Final_Project
{
    class Cards
    {
        private int cardValue;
        private string cardSuit;
        private string faceCard;

        public Cards(int cardValue, string cardSuit, string faceCard)
        {
            this.cardValue = cardValue;
            this.cardSuit = cardSuit;
            this.faceCard = faceCard;
        }

        public int CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                this.cardValue = value;
            }
        }

        public string CardSuit
        {
            get
            {
                return cardSuit;
            }
            set
            {
                this.cardSuit = value;
            }
        }

        public string FaceCard
        {
            get
            {
                return faceCard;
            }
            set
            {
                this.faceCard = value;
            }
        }
    }
}
