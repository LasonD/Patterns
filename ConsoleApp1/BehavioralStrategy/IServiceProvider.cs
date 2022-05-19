namespace ConsoleApp1.BehavioralStrategy
{
    public interface IServiceProvider
    {
        TService GetRequiredService<TService>();
    }
}
