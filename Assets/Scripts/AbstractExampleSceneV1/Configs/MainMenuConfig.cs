using UnityEngine;

namespace AbstractExampleSceneV1
{
    [CreateAssetMenu(menuName = "Configs/MainMenuConfig", fileName = "MainMenuConfig")]
    public class MainMenuConfig : ScriptableObject
    {
        [SerializeField] private Sprite _moneySprite;

        [SerializeField] private Color _energyColor;

        public Sprite MoneySprite => _moneySprite;
        public Color EnergyColor => _energyColor;
    }
}