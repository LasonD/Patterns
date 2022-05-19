namespace ConsoleApp1.StructuralVirtualProxy.Proxy
{
    public interface IMusicComplete
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        double AverageRating { get; }
        byte[] AudioBytes { get; }
    }
}
