using UnityEngine;

namespace DecoratorScripts
{
    public class HollyLightStatsDecorator : AbstractStatsDecorator
    {
        public HollyLightStatsDecorator(IStatsProvider statsProvider) : base(statsProvider) {}

        public override PlayerStats GetStatsInternal()
        {
            PlayerStats result = StatsProvider.GetStats() * 2;

            Debug.Log($"После HollyLightStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");

            return result;
        }
    }
}
