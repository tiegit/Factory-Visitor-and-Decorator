using System.Collections.Generic;

namespace DecoratorScripts
{
    public abstract class AbstractStatsDecorator : IStatsProvider
    {
        public readonly IStatsProvider StatsProvider;

        public AbstractStatsDecorator(IStatsProvider statsProvider) => StatsProvider = statsProvider;

        public PlayerStats GetStats() => GetStatsInternal();

        public abstract PlayerStats GetStatsInternal();
    }
}
