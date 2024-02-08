using UnityEngine;

namespace CoinSpawnerScripts 
{
    public class Coin : MonoBehaviour
    {
        private CoinRotator _coinRotator;

        private void Start()
        {
            _coinRotator = new CoinRotator(this);
        }

        private void FixedUpdate()
        {
            _coinRotator.Update();
        }
    }
}
