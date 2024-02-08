using UnityEngine;

namespace DecoratorScripts
{
    public class CrippleIntelliganceStatsDecorator : AbstractStatsDecorator
    {
        public CrippleIntelliganceStatsDecorator(IStatsProvider statsProvider) : base(statsProvider) { }

        public override PlayerStats GetStatsInternal()
        {
            PlayerStats result = StatsProvider.GetStats();
            result.Inttelligence = 0;

            Debug.Log($"После CrippleIntelliganceStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");

            return result;
        }
    }
}
