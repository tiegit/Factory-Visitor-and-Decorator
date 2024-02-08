using System;
using UnityEngine;

namespace DecoratorScripts
{
    public class SpecializationStatsDecorator : AbstractStatsDecorator
    {
        private Specialization _specialization;

        public SpecializationStatsDecorator(IStatsProvider statsProvider, Specialization specialization) : base(statsProvider) => _specialization = specialization;

        public override PlayerStats GetStatsInternal() => StatsProvider.GetStats() + GetSpecializationStats(_specialization);

        private PlayerStats GetSpecializationStats(Specialization specialization)
        {
            switch (specialization)
            {
                case Specialization.Thief:
                    PlayerStats result = new PlayerStats()
                    {
                        Strength = -10,
                        Inttelligence = 5,
                        Agility = 2,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");
                    return result;

                case Specialization.Mage:
                    PlayerStats result1 = new PlayerStats()
                    {
                        Strength = -5,
                        Inttelligence = 2,
                        Agility = -5,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result1.Strength}, интеллект {result1.Inttelligence}, ловкость: {result1.Agility}");
                    return result1;

                case Specialization.Barbarian:
                    PlayerStats result2 = new PlayerStats()
                    {
                        Strength = 10,
                        Inttelligence = 2,
                        Agility = -10,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result2.Strength}, интеллект {result2.Inttelligence}, ловкость: {result2.Agility}");
                    return result2;

                default:
                    throw new NotImplementedException($"Specialization {specialization} not found");
            }
        }
    }
}
