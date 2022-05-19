namespace ConsoleApp1.BehavioralStrategy
{
    public interface IMusicRepository
    {
        Task<Stream> GetMusicAsync(int id);
    }
}
