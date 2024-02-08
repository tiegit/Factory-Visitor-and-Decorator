using UnityEngine;

namespace DecoratorScripts
{
    public class WeaknessStatsDecorator : AbstractStatsDecorator
    {
        public WeaknessStatsDecorator(IStatsProvider statsProvider) : base(statsProvider) { }

        public override PlayerStats GetStatsInternal()
        {
            var result = StatsProvider.GetStats();
            result.Strength *= 0.8f;            

            Debug.Log($"После WeaknessStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");
            return result;
        }
    }
}
