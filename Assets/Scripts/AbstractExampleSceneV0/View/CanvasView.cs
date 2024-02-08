using UnityEngine;
using UnityEngine.UI;

namespace AbstractExampleSceneV0
{
    public class CanvasView : MonoBehaviour
    {
        [SerializeField] private Image _backgroundImage;
        [SerializeField] private Image _moneyImage;
        [SerializeField] private Image _energyImage;

        public void SetBackgroundColor(Color color) => _backgroundImage.color = color;
        
        public void SetMoneyImage(Sprite sprite) => _moneyImage.sprite = sprite;

        public void SetEnergyImageColor(Color color) => _energyImage.color = color;        
    }
}