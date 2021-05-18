using System;
using System.Collections.Generic;
using System.Text;

namespace SortCards
{
    public class StandartDeck<TCard> : IDeck<TCard>
    {
        public string Name { get; set; }
        public List<TCard> cards { get; private set; }
        public StandartDeck(string name, List<TCard> cards) : base(name, cards)
        {
            this.Name = name;
            this.cards = cards;
        }

    }
}
