using ConsoleApp1.Common;
using ConsoleApp1.StructuralVirtualProxy.Proxy;

namespace ConsoleApp1.StructuralVirtualProxy
{
    public class MusicDownloadService
    {
        private readonly IMusicRepository _musicRepository;

        public Task<IMusicComplete> DownloadMusicAsync(int musicId)
        {
            return _musicRepository.GetCompleteAsync(musicId);
        }

        public Task<IMusicComplete> GetDeferredDownloadMusic(int musicId)
        {
            return _musicRepository.GetLightweightMusicComplete(musicId);
        }
    }
}
