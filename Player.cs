namespace Whist;

public class Player {

    //En spiller har et navn og en hånd
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


    //Laver en hånd fra Deck og fjerner kortene fra den Decket
    public void CreateHand(Deck deck) {
        Hand.AddRange(deck.Cards.GetRange(0, 13));
        deck.Cards.RemoveRange(0, 13);
    }

    //Printer en spillers hånd
    public void PrintHand() {
        Console.WriteLine($"{Name}'s hand:");
        foreach (var card in Hand) {
            Console.WriteLine(card);
        }
    }

    //Sorterer en spillers hånd
    public void HandSort() {
        Hand.Sort();
    }
}