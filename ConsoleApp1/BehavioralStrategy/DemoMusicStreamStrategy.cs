using ConsoleApp1.BehavioralStrategy.Strategies;

namespace ConsoleApp1.BehavioralStrategy
{
    public class DemoMusicStreamStrategy : MusicStreamStrategyBase
    {
        protected override Task<Stream> ProcessMusicStreamAsync(Stream music)
        {
            throw new NotImplementedException();
        }

        public DemoMusicStreamStrategy(IMusicRepository musicRepository) : base(musicRepository)
        {
        }
    }
}
