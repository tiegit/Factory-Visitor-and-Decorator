using UnityEngine;

namespace CoinSpawnerScripts
{
    public class CoinRotator
    {
        private Coin _coin;
        private float _rotationSpeed = 250f;
        private float _rotationSpeedRandomizer = .75f;
        
        private float _startRotation;

        public CoinRotator(Coin coin)
        {
            _coin = coin;
            _startRotation = Random.Range(_rotationSpeed * _rotationSpeedRandomizer, _rotationSpeed);
        }
        public void Update()
        {
            _coin.transform.Rotate(0, _startRotation * Time.fixedDeltaTime, 0);
        }
    }
}