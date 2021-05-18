using System;
using System.Collections.Generic;

namespace SortCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cur = new StandartCardsDeck<StandartDeck<int>, int>();
            cur.CreateCardDeck(new StandartDeck<int>("first", new List<int> {1, 2, 3}));
            cur.CreateCardDeck(new StandartDeck<int>("second", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            cur.DeleteCardDeck("first");
            var c = cur.GetNamesDecks();
            var a = cur.GetDeckByName("second");
            cur.ShaffleDeck("second", ShuffleAlgo.Simple);
            var b = cur.GetDeckByName("second");
        }
    }
}
