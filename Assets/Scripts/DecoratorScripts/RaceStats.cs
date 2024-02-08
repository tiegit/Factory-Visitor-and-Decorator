using System;
using UnityEngine;

namespace DecoratorScripts
{
    public class RaceStats : IStatsProvider
    {
        private RaceType _raceType;

        public RaceStats(RaceType raceType) => _raceType = raceType;

        public PlayerStats GetStats()
        {
            switch (_raceType)
            {
                case RaceType.Orc:
                    PlayerStats result = new PlayerStats()
                    {
                        Strength = 50,
                        Inttelligence = 15,
                        Agility = 15,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");
                    return result;

                case RaceType.Elf:
                    PlayerStats result1 = new PlayerStats()
                    {
                        Strength = 35,
                        Inttelligence = 50,
                        Agility = 45,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result1.Strength}, интеллект {result1.Inttelligence}, ловкость: {result1.Agility}");
                    return result1;

                case RaceType.Human:
                    PlayerStats result2 = new PlayerStats()
                    {
                        Strength = 30,
                        Inttelligence = 45,
                        Agility = 35,
                    };
                    Debug.Log($"После SpecializationStatsDecorator сила: {result2.Strength}, интеллект {result2.Inttelligence}, ловкость: {result2.Agility}");
                    return result2;

                default:
                    throw new NotImplementedException($"RaceType {_raceType} not found");
            }
        }
    }
}
