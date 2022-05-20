namespace ConsoleApp1.MuisService.Strategies
{
    public class HighQualityMusicStreamStrategy : IMusicStreamStrategy
    {
        public virtual Task<Stream> GetProcessedMusicStreamAsync(Stream musicStream)
        {
            throw new NotImplementedException();
        }
    }
}
