namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public abstract class MusicStreamStrategyBase : IMusicStreamStrategy
    {
        private readonly IMusicRepository _musicRepository;

        protected MusicStreamStrategyBase(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<Stream> GetMusicStreamAsync(int musicId)
        {
            var music = await _musicRepository.GetMusicAsync(musicId);

            return await ProcessMusicStreamAsync(music);
        }

        protected abstract Task<Stream> ProcessMusicStreamAsync(Stream music);
    }
}
