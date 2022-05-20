namespace ConsoleApp1.MuisService.Strategies
{
    public class StenographySignedMusicStreamStrategy : HighQualityMusicStreamStrategy
    {
        private readonly IStenographyStamper _stenographyStamper;

        public StenographySignedMusicStreamStrategy(IStenographyStamper stenographyStamper)
        {
            _stenographyStamper = stenographyStamper;
        }

        public override async Task<Stream> GetProcessedMusicStreamAsync(Stream musicStream)
        {
            var highQualityStream = await base.GetProcessedMusicStreamAsync(musicStream);

            var streamWithStamp = await _stenographyStamper.SignMusicStreamAsync(highQualityStream);

            return streamWithStamp;
        }
    }
}
