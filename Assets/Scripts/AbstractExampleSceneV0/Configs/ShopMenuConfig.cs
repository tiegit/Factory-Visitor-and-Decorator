using UnityEngine;

namespace AbstractExampleSceneV0
{
    [CreateAssetMenu(menuName = "Configs/ShopMenuConfigV0", fileName = "ShopMenuConfigV0")]
    public class ShopMenuConfig : ScriptableObject
    {
        [SerializeField] private Sprite _moneySprite;

        [SerializeField] private Color _energyColor;

        [SerializeField] private Color _backgroundColor;

        public Sprite MoneySprite => _moneySprite;
        public Color EnergyColor => _energyColor;
        public Color BackgroundColor => _backgroundColor;
    }
}