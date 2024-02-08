using UnityEngine;

namespace AbstractExampleSceneV0
{
    [CreateAssetMenu(menuName = "Configs/MainMenuConfigV0", fileName = "MainMenuConfigV0")]
    public class MainMenuConfig : ScriptableObject
    {
        [SerializeField] private Sprite _moneySprite;

        [SerializeField] private Color _energyColor;

        [SerializeField] private Color _backgroundColor;

        public Sprite MoneySprite => _moneySprite;
        public Color EnergyColor => _energyColor;
        public Color BackgroundColor => _backgroundColor;
    }
}