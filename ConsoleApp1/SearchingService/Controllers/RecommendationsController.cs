using ConsoleApp1.MuisService;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.SearchingService.Controllers
{
    public class RecommendationsController : ControllerBase
    {
        private readonly IRecommendationsService _recommendationsService;
        private readonly IUserManager _userManager;

        public RecommendationsController(IRecommendationsService recommendationsService, IUserManager userManager)
        {
            _recommendationsService = recommendationsService;
            this._userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecommendations()
        {
            var user = _userManager.GetCurrentUser();

            var recommendations = await _recommendationsService.GetRecommendedMusicForUserAsync(user);

            return Ok(recommendations);
        }
    }
}
