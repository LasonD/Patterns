﻿namespace ConsoleApp1.BehavioralStrategy.Strategies
{
    public class StandardQualityMusicStreamStrategy : IMusicStreamStrategy
    {
        public Task<Stream> GetProcessedMusicStreamAsync(Stream musicStream)
        {
            throw new NotImplementedException();
        }
    }
}
