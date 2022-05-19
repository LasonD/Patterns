using ConsoleApp1.Common;

namespace ConsoleApp1.StructuralVirtualProxy.Proxy
{
    public class MusicCompleteVirtualProxy : IMusicComplete
    {
        private readonly IMusicRepository _musicRepository;
        private MusicComplete? _actualMusicComplete;

        public MusicCompleteVirtualProxy(IMusicRepository musicRepository, int id, string name, string description, double averageRating)
        {
            _musicRepository = musicRepository;
            Id = id;
            Name = name;
            Description = description;
            AverageRating = averageRating;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double AverageRating { get; }

        public byte[] AudioBytes
        {
            get
            {
                _actualMusicComplete ??= _musicRepository.GetCompleteAsync(Id).Result as MusicComplete;

                return _actualMusicComplete?.AudioBytes ?? throw new Exception("Music couldn't be downloaded");
            }
        }
    }
}
