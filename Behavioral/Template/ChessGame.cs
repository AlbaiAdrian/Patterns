namespace Template;

class ChessGame : Game
{
    protected override void Initialize()
    {
        Console.WriteLine("Chess Game Initialized! Set up the board.");
    }

    protected override void StartPlay()
    {
        Console.WriteLine("Chess Game Started. Make your move!");
    }

    protected override void EndPlay()
    {
        Console.WriteLine("Chess Game Finished!");
    }
}

