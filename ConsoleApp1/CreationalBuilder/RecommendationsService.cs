using ConsoleApp1.Common;
using ConsoleApp1.CreationalBuilder.Builder;

namespace ConsoleApp1.CreationalBuilder
{
    public interface IRecommendationsService
    {
        Task<IEnumerable<Music>> GetRecommendedMusicForUserAsync(MusicStoreUser user);
    }

    public class RecommendationsService : IRecommendationsService
    {
        private readonly IMusicRepository _musicRepository;

        public RecommendationsService(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<IEnumerable<Music>> GetRecommendedMusicForUserAsync(MusicStoreUser user)
        {
            var userCollection = await _musicRepository.GetAllMusicFromUserCollection(user.UserId);

            var preferredGenres = GetUserPreferredGenres(userCollection);

            var searchSpecification = BuildSearchSpecification(preferredGenres);

            return await _musicRepository.GetAllByCriteria(searchSpecification);
        }

        private static SearchSpecification BuildSearchSpecification(IEnumerable<string> preferredGenres)
        {
            var specificationBuilder = new MusicSearchSpecificationBuilder();

            foreach (var genre in preferredGenres)
            {
                specificationBuilder.AddGenre(genre);
            }

            var searchSpecification = specificationBuilder
                .AddLimit(20)
                .Build();

            return searchSpecification;
        }

        private IEnumerable<string> GetUserPreferredGenres(IEnumerable<Music> userCollection)
        {
            var genresWithCounts = userCollection
                .GroupBy(x => x.Genre.ToLower())
                .Select(x => (x.First().Genre, x.Count()))
                .OrderByDescending(x => x.Item2)
                .ToList();

            var genresCountToTake = genresWithCounts.Count / 2;

            return genresWithCounts.Take(genresCountToTake).Select(x => x.Genre);
        }
    }
}
