namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public class StandardQualityMusicStreamStrategy : MusicStreamStrategyBase
    {
        protected override Task<Stream> ProcessMusicStreamAsync(Stream music)
        {
            throw new NotImplementedException();
        }

        public StandardQualityMusicStreamStrategy(IMusicRepository musicRepository) : base(musicRepository)
        {
        }
    }
}
