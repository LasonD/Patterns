namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public class HighQualityMusicStreamStrategy : IMusicStreamStrategy
    {
        public virtual Task<Stream> GetProcessedMusicStreamAsync(Stream musicStream)
        {
            throw new NotImplementedException();
        }
    }
}
