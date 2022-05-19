namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public class StenographySignedMusicStreamStrategy : MusicStreamStrategyBase
    {
        private readonly IStenographyStamper _stenographyStamper;

        public StenographySignedMusicStreamStrategy(IMusicRepository musicRepository,
            IStenographyStamper stenographyStamper)
            : base(musicRepository)
        {
            _stenographyStamper = stenographyStamper;
        }

        protected override Task<Stream> ProcessMusicStreamAsync(Stream music)
        {
            throw new NotImplementedException();
        }
    }
}
