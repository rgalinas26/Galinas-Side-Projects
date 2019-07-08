using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GalinasSideProject2._0.Classes;

namespace GalinasSideProject2._0.Classes
{
    class Deck
    {
        public Stack<Card> deck;

        public Deck()
        {
            Build();
        }

        public void Build()
        {
            deck = new Stack<Card>(60);
            using (StreamReader sr = new StreamReader(@"C:\Users\BGalinas\GitRepos\Galinas-Side-Projects\MTGSide\Modern Humans Decklist.txt"))
            {
                while (!sr.EndOfStream)
                {
                    bool isLand = false;
                    string line = sr.ReadLine();
                    string[] cardCreator = line.Split("|");
                    if (cardCreator[3] == "true")
                    {
                        isLand = true;
                    }
                    Card card = new Card(cardCreator[0], cardCreator[1], int.Parse(cardCreator[2]), isLand);
                    deck.Push(card);
                }
            }
        }

        public List<string> DisplayCardsInDeck()
        {
            List<string> displayDeck = new List<string>();
            foreach(Card card in deck)
            {
                displayDeck.Add(card.Name + "|" + card.ManaCost);
            }
            return displayDeck;
        }

        public Card Deal()
        {
            return this.deck.Pop();
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Card[] values = deck.ToArray();
            deck.Clear();
            foreach (Card value in values.OrderBy(x => rnd.Next()))
                deck.Push(value);
        }
        public void Clear()
        {
            deck.Clear();
        }

    }
}
