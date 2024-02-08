using UnityEngine;

namespace DecoratorScripts
{
    public class Player
    {
        private RaceType _race;
        private Specialization _specialization;
        
        private IStatsProvider _statsProvider;

        public Player(RaceType race, Specialization specialization)
        {
            _race = race;
            _specialization = specialization;

            _statsProvider = new ResetBaseRaceAndSpecializationStatsDecorator(new WeaknessStatsDecorator(new SpecializationStatsDecorator(new RaceStats(_race), _specialization)), _race, _specialization); // вся магия здесь

            Debug.Log($"ИТОГО сила: {_statsProvider.GetStats().Strength}, интеллект {_statsProvider.GetStats().Inttelligence}, ловкость: {_statsProvider.GetStats().Agility}");
        }

        private void PlayerDecorators() // смысловой нагрузки нет - это шпаргалка
        {
            _statsProvider = new RaceStats(_race); // по типу рассы

            _statsProvider = new SpecializationStatsDecorator(_statsProvider, _specialization); // по специализации

            _statsProvider = new ResetBaseRaceAndSpecializationStatsDecorator(_statsProvider, _race, _specialization); // рестарт текущего товарища

            _statsProvider = new ApplyOrcFrenzyStatsDecorator(_statsProvider); // добаляет статы орка

            _statsProvider = new CrippleIntelliganceStatsDecorator(_statsProvider); // интеллект падает до 0

            _statsProvider = new HollyLightStatsDecorator(_statsProvider); // умножает все статы в 2 раза

            _statsProvider = new WeaknessStatsDecorator(_statsProvider); // на 20% снижает все статы
        }
    }
}
