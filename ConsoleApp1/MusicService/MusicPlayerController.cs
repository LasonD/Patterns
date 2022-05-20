using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.MuisService
{
    public class MusicPlayerController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly IMusicPlayerService _palyerService;

        public MusicPlayerController(IUserManager userManager, IMusicPlayerService palyerService)
        {
            _userManager = userManager;
            _palyerService = palyerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetMusicStream(int musicId)
        {
            var user = _userManager.GetCurrentUser();

            var processedMusicStream = await _palyerService.StreamMusicBasedOnSubscription(musicId, user.Subscription);

            return File(processedMusicStream, "audio/mpeg");
        }
    }
}
