using System;
using UnityEngine;

namespace AbstractExampleSceneV1
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private CanvasView _canvasView;
        [SerializeField] private CanvasesConfig _config;

        [SerializeField] private MenuType _menuType;
        [SerializeField] private ResourceType _resourceType;

        private MenuSwitcher _menuSwitcher;        

        private void Awake() => _menuSwitcher = new MenuSwitcher(_canvasView, _config);

        [ContextMenu("SetResurceView")]
        public void SetResurceView()
        {
            MenuFactory menuFactory;

            switch (_menuType)
            {
                case MenuType.MainMenu:
                    menuFactory = new MainMenuFactory();
                    break;

                case MenuType.ShopMenu:
                    menuFactory = new ShopMenuFactory();
                    break;

                default:
                    throw new ArgumentException(nameof(_menuType));
            }

            _menuSwitcher.SetResource(menuFactory.Create(_resourceType));
        }
    }
}
