namespace DecoratorScripts
{
    public class PlayerStats
    {
        public float Strength { get; set; }
        public float Inttelligence { get; set; }
        public float Agility { get; set; }

        public static PlayerStats operator + (PlayerStats x, PlayerStats y)
        {
            return new PlayerStats()
            {
                Strength = x.Strength + y.Strength,
                Inttelligence = x.Inttelligence + y.Inttelligence,
                Agility = x.Agility + y.Agility,
            };
        }

        public static PlayerStats operator * (PlayerStats x, float n)
        {
            return new PlayerStats()
            {
                Strength = x.Strength * n,
                Inttelligence = x.Inttelligence * n,
                Agility = x.Agility * n,
            };
        }

        public static PlayerStats operator / (PlayerStats x, float n)
        {
            return new PlayerStats()
            {
                Strength = x.Strength / n,
                Inttelligence = x.Inttelligence / n,
                Agility = x.Agility / n,
            };
        }
    }
}
