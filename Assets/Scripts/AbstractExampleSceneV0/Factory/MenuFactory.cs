using System;
using System.Collections;
using System.Collections.Generic;

namespace AbstractExampleSceneV0
{
    public class MenuFactory
    {
        private List<CanvasViewSetter> _setters;

        public IEnumerable Create(MenuType menuType)
        {
            switch (menuType)
            {
                case MenuType.MainMenu:

                    _setters = new List<CanvasViewSetter>()
                        {
                        new MainMenuBackgroundViewSetter(),
                        new MainMenuMoneyViewSetter(),
                        new MainMenuEnergyViewSetter(),
                        };

                    return _setters;

                case MenuType.ShopMenu:
                    _setters = new List<CanvasViewSetter>()
                        {
                        new ShopMenuBackgroundViewSetter(),
                        new ShopMenuMoneyViewSetter(),
                        new ShopMenuEnergyViewSetter(),
                        };

                    return _setters;

                default:
                    throw new ArgumentException(nameof(menuType));
            }
        }
    }
}