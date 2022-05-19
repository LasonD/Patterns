namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public class HighQualityMusicStreamStrategy : MusicStreamStrategyBase
    {
        protected override Task<Stream> ProcessMusicStreamAsync(Stream music)
        {
            throw new NotImplementedException();
        }

        public HighQualityMusicStreamStrategy(IMusicRepository musicRepository) : base(musicRepository)
        {
        }
    }
}
