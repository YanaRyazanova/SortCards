using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortCards
{
    public class StandartCardsDeck<TDeck, TCard> : ICardsDeck<TDeck, TCard>
    where TDeck : IDeck<TCard>
    {
        private List<TDeck> decks;

        public StandartCardsDeck()
        {
            decks = new List<TDeck>();
        }

        public bool CreateCardDeck(TDeck newDeck)
        {
            if (!decks.Contains(newDeck))
                decks.Add(newDeck);
            return true;
        }

        public bool DeleteCardDeck(string nameDeck)
        {
            var deck = GetDeckByName(nameDeck);
            if (decks.Contains(deck))
                decks.Remove(deck);
            return true;
        }

        public List<string> GetNamesDecks()
        {
            var res = decks.Select(deck => deck.Name).ToList();
            return res;
        }

        public bool ShaffleDeck(string nameDeck, ShuffleAlgo algo)
        {
            var currentDeck = GetDeckByName(nameDeck);
            var currentIndex = decks.IndexOf(currentDeck);
            List<TCard> shiffled = null;
            if (algo == ShuffleAlgo.Simple)
                shiffled = FisherYates<TCard>.Shuffle(currentDeck.cards);
            decks[currentIndex].ChangeCards(shiffled);
            return true;
        }

        public TDeck GetDeckByName(string name)
        {
            TDeck res = null;
            foreach (var deck in decks.Where(deck => deck.Name == name))
            {
                res = deck;
            }

            return res;
        }

        private static class FisherYates<TCard>
        {
            private static readonly Random r = new Random();
            public static List<TCard> Shuffle(List<TCard> deck)
            {
                for (var n = deck.Count - 1; n > 0; --n)
                {
                    var k = r.Next(n + 1);
                    var temp = deck[n];
                    deck[n] = deck[k];
                    deck[k] = temp;
                }

                return deck;
            }
        }
    }
}
