namespace ConsoleApp1.BehavioralStrategy
{
    public interface IStenographyStamper
    {
        Task<Stream> SignMusicStreamAsync(Stream originalStream);
    }
}
