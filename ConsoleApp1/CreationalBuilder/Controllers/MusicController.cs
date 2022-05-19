using ConsoleApp1.BehavioralStrategy;
using ConsoleApp1.Common;
using ConsoleApp1.CreationalBuilder.Builder;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.CreationalBuilder.Controllers
{
    public class MusicController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly IMusicRepository _musicRepository;

        public MusicController(IUserManager userManager, IMusicRepository musicRepository)
        {
            _userManager = userManager;
            _musicRepository = musicRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyPrivateMusic(string[] genres)
        {
            var user = _userManager.GetCurrentUser();

            var builder = new MusicSearchSpecificationBuilder()
                .IncludeUserPrivateMusic(user.UserId);

            foreach (var genre in genres)
            {
                builder.AddGenre(genre);
            }

            var specification = builder.Build();

            var privateMusic = await _musicRepository.GetAllByCriteria(specification);

            return Ok(privateMusic);
        }

        [HttpGet]
        public async Task<IActionResult> GetMusicFeed(string[] genres)
        {
            var user = _userManager.GetCurrentUser();

            var builder = new MusicSearchSpecificationBuilder();

            foreach (var genre in genres)
            {
                builder.AddGenre(genre);
            }

            if (user.Subscription == Subscription.Premium)
            {
                builder.IncludePremiumMusic();
            }

            builder.OrderBy(m => m.AverageRating);

            var specification = builder.Build();

            var privateMusic = await _musicRepository.GetAllByCriteria(specification);

            return Ok(privateMusic);
        }
    }
}
