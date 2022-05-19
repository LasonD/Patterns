using ConsoleApp1.CreationalBuilder.Builder;

namespace ConsoleApp1.Common
{
    public interface IMusicRepository
    {
        Task<Stream> GetStreamAsync(int id);

        Task<IEnumerable<Music>> GetAllByCriteria(SearchSpecification specification);

        Task<IEnumerable<Music>> GetAllMusicFromUserCollection(int userId); 
    }
}
