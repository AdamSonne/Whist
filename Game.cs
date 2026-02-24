namespace Whist; 
using System;
using System.Collections.Generic;

public class Game {
    public List<Player> Players {
        get; private set;
    }
    public Deck Deck {
        get; private set;
    }

    //Dette er katten
    public List<Card> RemainingCards {
        get; private set;
    }

    public Game(List<string> playerNames) {
        if (playerNames.Count != 4)
            throw new ArgumentException("Whist requires exactly 4 players.");

        // Create players
        Players = new List<Player>();
        foreach (var name in playerNames) {
            Players.Add(new Player(name));
        }

        // Create and shuffle deck
        Deck = new Deck();
        Deck.Shuffle();

        // Deal cards to players
        DealCards();
    }

    //Dealer kort til hver spiller og sorterer deres kort
    private void DealCards() {
        foreach (var player in Players) {
            player.CreateHand(Deck);   // dealer 13 kort
            player.HandSort();         // sorterer hånden
        }

        RemainingCards = new List<Card>(Deck.Cards); //Laver katten miaw :3
    }

    //Til at printe hver spillers hånd
    public void PrintHands() {
        foreach (var player in Players) {
            player.PrintHand();
            Console.WriteLine();
        }

        Console.WriteLine($"Cards remaining in deck: {Deck.Cards.Count}");
    }

    //Til at printe Katten (3 sidste kort)
    public void PrintKatten() {
        Console.WriteLine("Katten:");
        foreach (var card in RemainingCards) {
            Console.WriteLine(card);
        }
    }
}