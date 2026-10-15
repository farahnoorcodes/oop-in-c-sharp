using System.Collections.Generic;
using System;
namespace cards_game
{
    public class deck
    {
        List<card> cards = new List<card>();
        public  deck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new card(suits[i], j));
                }
            }
        }
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i, cards.Count);
                card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        public card dealcard()
        {
            if (cards.Count > 0)
            {
                card top = cards[0];
                cards.RemoveAt(0);
                Console.WriteLine($"Dealt Card: {top.suit} {top.value}");   
                return top;
                
            }
            else
            {
                Console.WriteLine("No more cards to deal.");
                return null;    
            }
        }
    }
}
