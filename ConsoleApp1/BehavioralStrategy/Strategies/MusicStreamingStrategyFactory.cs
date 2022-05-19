using ConsoleApp1.Common;

namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public interface IMusicStreamingStrategyFactory
    {
        IMusicStreamStrategy CreateStrategy(MusicStoreUser user);
    }

    public class MusicStreamingStrategyFactory : IMusicStreamingStrategyFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public MusicStreamingStrategyFactory(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public IMusicStreamStrategy CreateStrategy(MusicStoreUser user)
        {
            return user.Subscription switch
            {
                Subscription.None => new DemoMusicStreamStrategy(_serviceProvider.GetRequiredService<IMusicRepository>()),
                Subscription.Standard => new StandardQualityMusicStreamStrategy(_serviceProvider.GetRequiredService<IMusicRepository>()),
                Subscription.Advanced => new HighQualityMusicStreamStrategy(_serviceProvider.GetRequiredService<IMusicRepository>()),
                Subscription.Premium => new StenographySignedMusicStreamStrategy(_serviceProvider.GetRequiredService<IMusicRepository>(), _serviceProvider.GetRequiredService<IStenographyStamper>()),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
