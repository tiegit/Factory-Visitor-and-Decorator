using UnityEngine;

namespace AbstractExampleSceneV1
{
    [CreateAssetMenu(menuName = "Configs/CanvasesConfig", fileName = "CanvasesConfig")]
    public class CanvasesConfig : ScriptableObject
    {
        [Space(20), SerializeField] private MainMenuConfig _mainMenuConfig;
        [Space(20), SerializeField] private ShopMenuConfig _shopMenuConfig;

        public MainMenuConfig MainMenuConfig => _mainMenuConfig;
        public ShopMenuConfig ShopMenuConfig => _shopMenuConfig;
    }
}