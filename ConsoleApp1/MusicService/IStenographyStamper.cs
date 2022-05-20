namespace ConsoleApp1.MuisService
{
    public interface IStenographyStamper
    {
        Task<Stream> SignMusicStreamAsync(Stream originalStream);
    }
}
