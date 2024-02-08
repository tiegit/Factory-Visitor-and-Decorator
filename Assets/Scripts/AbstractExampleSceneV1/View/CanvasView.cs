using UnityEngine;
using UnityEngine.UI;

namespace AbstractExampleSceneV1
{
    public class CanvasView : MonoBehaviour
    {
        [SerializeField] private Image _moneyImage;
        [SerializeField] private Image _energyImage;
                
        public void SetMoneyImage(Sprite sprite) => _moneyImage.sprite = sprite;

        public void SetEnergyImageColor(Color color) => _energyImage.color = color;        
    }
}