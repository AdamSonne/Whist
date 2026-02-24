namespace Whist;
class Program {
    static void Main() {
        var playerNames = new List<string> { "Alice", "Bob", "Charlie", "Diana" };

        // Start game
        Game game = new Game(playerNames);

        // Print all hands
        game.PrintHands();

        //Print katten
        game.PrintKatten();
    }


}