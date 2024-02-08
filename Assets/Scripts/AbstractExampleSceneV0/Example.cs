using UnityEngine;

namespace AbstractExampleSceneV0
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private CanvasView _canvasView;
        [SerializeField] private CanvasesConfig _config;

        private MenuSwitcher _menuSwitcher;

        private void Awake() => _menuSwitcher = new MenuSwitcher(_canvasView, _config);
        
        private void Update() => _menuSwitcher.Update();        
    }
}
