namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public interface IMusicStreamStrategy
    {
        Task<Stream> GetMusicStreamAsync(int musicId);
    }
}
