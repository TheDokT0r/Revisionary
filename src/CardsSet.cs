using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisionary
{
    public class CardsSet //An entire set of cards
    {
        public string title;
        public string subject;
        public Card[] cards;

        public CardsSet(string title, string subject, Card[] cards)
        {
            this.title = title;
            this.subject = subject;
            this.cards = cards;
        }


        public void AddCard(Card card)
        {
            var temp = new Card[cards.Length + 1];
            cards.CopyTo(temp, 0);
            temp[temp.Length - 1] = card;
            cards = temp;
        }
    }
}
