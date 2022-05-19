using ConsoleApp1.BehavioralStrategy.Strategies;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.BehavioralStrategy
{
    public class MusicPlayerController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly IMusicStreamingStrategyFactory _musicStreamingStrategyFactory;

        public MusicPlayerController(IUserManager userManager, IMusicStreamingStrategyFactory musicStreamingStrategyFactory)
        {
            _userManager = userManager;
            _musicStreamingStrategyFactory = musicStreamingStrategyFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetMusicStream(int musicId)
        {
            var user = _userManager.GetCurrentUser();

            var streamingStrategy = _musicStreamingStrategyFactory.CreateStrategy(user);

            var musicStream = await streamingStrategy.GetMusicStreamAsync(musicId);

            return File(musicStream, "audio/mpeg");
        }
    }
}
