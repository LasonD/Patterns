namespace ConsoleApp1.StructuralVirtualProxy.Proxy
{
    public class MusicComplete : IMusicComplete
    {
        public MusicComplete(int id, string name, string description, double averageRating, byte[] audioBytes)
        {
            Id = id;
            Name = name;
            Description = description;
            AverageRating = averageRating;
            AudioBytes = audioBytes;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double AverageRating { get; }
        public byte[] AudioBytes { get; }
    }
}
