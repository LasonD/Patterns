using ConsoleApp1.Common;
using ConsoleApp1.MuisService.Strategies;

namespace ConsoleApp1.MuisService
{
    public interface IMusicPlayerService
    {
        Task<Stream> StreamMusicBasedOnSubscription(int musicId, Subscription subscription);
    }

    public class MusicPlayerService : IMusicPlayerService
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IMusicStreamingStrategyFactory _streamingStrategyFactory;

        public async Task<Stream> StreamMusicBasedOnSubscription(int musicId, Subscription subscription)
        {
            var rawMusicStream = await _musicRepository.GetStreamAsync(musicId);

            var streamingStrategy = _streamingStrategyFactory.CreateStrategy(subscription);

            var processedMusicStream = await streamingStrategy.GetProcessedMusicStreamAsync(rawMusicStream);

            return processedMusicStream;
        }
    }
}
