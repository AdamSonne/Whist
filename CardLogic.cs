namespace Whist;
using System;
public class Deck {
    public List<Card> Cards { get; private set; }

    public Deck() {
        Cards = new List<Card>();
        for (int suit = 1; suit <= 4; suit++) {
            for (int rank = 1; rank <= 13; rank++) {
                Cards.Add(new Card(rank, suit));
            }
        }
    }
    public void Shuffle() {
        Random rng = new Random();
        int n = Cards.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n + 1);
            var temp = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = temp;
        }
    }

    public void PrintDeck() {
        foreach (var card in Cards) {
            Console.WriteLine(card);
        }
    }
}

public class Card : IComparable<Card> {
    // Ranks: Ace = 1, ..., King = 13
    public int Rank { get; set; }
    
    // Suits: Spades = 1, Hearts = 2, Clubs = 3, Diamonds = 4
    public int Suit { get; set; }

    public Card(int rank, int suit) {
        Rank = rank;
        Suit = suit;
    }

    public int CompareTo(Card c) {
        int compareSuits = this.Suit.CompareTo(c.Suit);
        if (compareSuits != 0)
            return compareSuits;
        return this.Rank.CompareTo(c.Rank);
    }

    public override string ToString() {
        string[] suits = { "", "Spades", "Hearts", "Clubs", "Diamonds" };
        string[] ranks = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        return $"{ranks[Rank]} of {suits[Suit]}";
    }
}