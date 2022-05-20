using ConsoleApp1.PlayerService.Proxy;
using ConsoleApp1.SearchingService.Builder;

namespace ConsoleApp1.Common
{
    public interface IMusicRepository
    {
        Task<Stream> GetStreamAsync(int id);

        Task<IEnumerable<Music>> GetAllByCriteria(SearchSpecification specification);

        Task<IEnumerable<Music>> GetAllMusicFromUserCollection(int userId);

        Task<IMusicComplete> GetCompleteAsync(int musicId);
        Task<IMusicComplete> GetLightweightMusicComplete(int musicId);
    }
}
