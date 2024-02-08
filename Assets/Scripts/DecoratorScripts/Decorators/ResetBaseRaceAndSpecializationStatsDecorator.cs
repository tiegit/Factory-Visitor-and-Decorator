using UnityEngine;

namespace DecoratorScripts
{
    public class ResetBaseRaceAndSpecializationStatsDecorator : AbstractStatsDecorator
    {
        private RaceType _raceType;
        private Specialization _specialization;

        public ResetBaseRaceAndSpecializationStatsDecorator(IStatsProvider statsProvider, RaceType raceType, Specialization specialization) : base(statsProvider)
        { 
            _raceType = raceType;
            _specialization = specialization;
        }

        public override PlayerStats GetStatsInternal()
        {
            PlayerStats result = new SpecializationStatsDecorator(new RaceStats(_raceType), _specialization).GetStats();
            
            Debug.Log($"После ResetBaseRaceAndSpecializationStatsDecorator сила: {result.Strength}, интеллект {result.Inttelligence}, ловкость: {result.Agility}");

            return result;
        }
    }
}
