using ConsoleApp1.Common;

namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public interface IMusicStreamingStrategyFactory
    {
        IMusicStreamStrategy CreateStrategy(Subscription subscription);
    }

    public class MusicStreamingStrategyFactory : IMusicStreamingStrategyFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public MusicStreamingStrategyFactory(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public IMusicStreamStrategy CreateStrategy(Subscription subscription)
        {
            return subscription switch
            {
                Subscription.None => new DemoMusicStreamStrategy(),
                Subscription.Standard => new StandardQualityMusicStreamStrategy(),
                Subscription.Advanced => new HighQualityMusicStreamStrategy(),
                Subscription.Premium => new StenographySignedMusicStreamStrategy(_serviceProvider.GetRequiredService<IStenographyStamper>()),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
