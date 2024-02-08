using UnityEngine;

namespace AbstractExampleSceneV0
{
    [CreateAssetMenu(menuName = "Configs/CanvasesConfigV0", fileName = "CanvasesConfigV0")]
    public class CanvasesConfig : ScriptableObject
    {
        [Space(20), SerializeField] private MainMenuConfig _mainMenuConfig;
        [Space(20), SerializeField] private ShopMenuConfig _shopMenuConfig;

        public MainMenuConfig MainMenuConfig => _mainMenuConfig;
        public ShopMenuConfig ShopMenuConfig => _shopMenuConfig;
    }
}