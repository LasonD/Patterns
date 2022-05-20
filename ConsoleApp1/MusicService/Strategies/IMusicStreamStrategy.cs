namespace ConsoleApp1.MuisService.Strategies
{
    public interface IMusicStreamStrategy
    {
        Task<Stream> GetProcessedMusicStreamAsync(Stream musicStream);
    }
}
