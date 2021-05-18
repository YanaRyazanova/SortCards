using System;
using System.Collections.Generic;
using System.Text;

namespace SortCards
{
    public interface ICardsDeck<TDeck, TCard>
    {
        public bool CreateCardDeck(TDeck newDeck);
        public bool DeleteCardDeck(string deletedDeck);
        public List<string> GetNamesDecks();
        public bool ShaffleDeck(string nameDeck, ShuffleAlgo algo);
        public TDeck GetDeckByName(string name);
    }
}
