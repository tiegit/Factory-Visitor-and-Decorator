using UnityEngine;

namespace DecoratorScripts
{
    public class ApplyOrcFrenzyStatsDecorator : AbstractStatsDecorator
    {
        public ApplyOrcFrenzyStatsDecorator(IStatsProvider statsProvider) : base(statsProvider) { }

        public override PlayerStats GetStatsInternal()
        {
            PlayerStats result = StatsProvider.GetStats() + new RaceStats(RaceType.Orc).GetStats();

            Debug.Log($"После ApplyOrcFrenzyStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");

            return result;
        }
    }
}
