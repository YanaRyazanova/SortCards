using System;
using System.Collections.Generic;
using System.Text;

namespace SortCards
{
    public abstract class IDeck<Card>
    {
        public string Name { get; set; }
        public List<Card> cards { get; private set; }

        public IDeck(string name, List<Card> cards)
        {
            this.Name = name;
            this.cards = cards;
        }
        public void ChangeCards(List<Card> newCards)
        {
            cards = newCards;
        }
    }
}
