namespace Whist;

public class Player {
    public string Name {
        get; set;
    }
    public List<Card> Hand {
        get; private set;
    }

    public Player(string name) {
        Name = name;
        Hand = new List<Card>();
    }

    public void CreateHand(Deck deck) {
        Hand.AddRange(deck.Cards.GetRange(0, 13));
        deck.Cards.RemoveRange(0, 13);
    }

    public void PrintHand() {
        Console.WriteLine($"{Name}'s hand:");
        foreach (var card in Hand) {
            Console.WriteLine(card);
        }
    }

    public void HandSort() {
        Hand.Sort();
    }
}