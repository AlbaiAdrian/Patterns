namespace Template;

abstract class Game
{
    // Template method
    public void Play()
    {
        Initialize();
        StartPlay();
        EndPlay();
    }

    protected abstract void Initialize();
    protected abstract void StartPlay();
    protected abstract void EndPlay();
}
