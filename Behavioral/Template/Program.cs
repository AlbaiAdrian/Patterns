// See https://aka.ms/new-console-template for more information
using Template;

Console.WriteLine("Hello, Template!");

Game game;

Console.WriteLine("--- Playing Football ---");
game = new FootballGame();
game.Play();

Console.WriteLine("\n--- Playing Chess ---");
game = new ChessGame();
game.Play();