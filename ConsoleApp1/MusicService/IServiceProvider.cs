namespace ConsoleApp1.MuisService
{
    public interface IServiceProvider
    {
        TService GetRequiredService<TService>();
    }
}
