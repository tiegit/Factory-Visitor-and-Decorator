using System.Collections.Generic;
using UnityEngine;

namespace AbstractExampleSceneV0
{
    public class MenuSwitcher
    {
        private MenuFactory _menuFactory;

        private CanvasView _canvasView;
        private CanvasesConfig _config;
        private List<CanvasViewSetter> _setters;

        public MenuSwitcher(CanvasView canvasView, CanvasesConfig config)
        {
            _canvasView = canvasView;
            _config = config;

            _menuFactory= new MenuFactory();

            SetCanvas(SetMenu(MenuType.MainMenu));
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                SetCanvas(SetMenu(MenuType.MainMenu));
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
                SetCanvas(SetMenu(MenuType.ShopMenu));
        }

        public void SetCanvas(IEnumerable<CanvasViewSetter> setters)
        {
            _setters = new List<CanvasViewSetter>(setters);

            for (int i = 0; i < _setters.Count; i++)
            {
                _setters[i].SetCanvasView(_canvasView, _config);
            }
        }

        private IEnumerable<CanvasViewSetter> SetMenu(MenuType menuType) => (IEnumerable<CanvasViewSetter>) _menuFactory.Create(menuType);
    }
}
