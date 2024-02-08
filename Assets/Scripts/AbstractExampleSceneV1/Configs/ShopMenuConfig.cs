using UnityEngine;

namespace AbstractExampleSceneV1
{
    [CreateAssetMenu(menuName = "Configs/ShopMenuConfig", fileName = "ShopMenuConfig")]
    public class ShopMenuConfig : ScriptableObject
    {
        [SerializeField] private Sprite _moneySprite;

        [SerializeField] private Color _energyColor;

        public Sprite MoneySprite => _moneySprite;
        public Color EnergyColor => _energyColor;
    }
}