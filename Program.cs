namespace Whist;
class Program{
    static void Main() {
        Deck deck = new Deck();
            deck.Shuffle();

            Player player1 = new Player("Alice");
            Player player2 = new Player("Bob");

            player1.CreateHand(deck);
            player2.CreateHand(deck);

            player1.HandSort();
            player2.HandSort();

            player1.PrintHand();
            Console.WriteLine();
            player2.PrintHand();

            Console.WriteLine($"\nCards left in deck: {deck.Cards.Count}");
    }

    
}