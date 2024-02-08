using UnityEngine;
using Random = UnityEngine.Random;

namespace CoinSpawnerScripts
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _coinPrefab;
        [SerializeField] private int _coinCount = 10;
        
        [SerializeField] private float _minAxisPositionX = -3f;
        [SerializeField] private float _maxAxisPositionX = 3f;
        [SerializeField] private float _minAxisPositionY = -3f;
        [SerializeField] private float _maxAxisPositionY = 3f;

        private int _spawnedCoinValue;

        private void OnValidate()
        {
            if (_minAxisPositionX >= _maxAxisPositionX)
                _maxAxisPositionX = _minAxisPositionX + 1;

            if (_minAxisPositionY >= _maxAxisPositionY)
                _maxAxisPositionY = _minAxisPositionY + 1;
        }

        private void Start()
        {
            float coinRadius = _coinPrefab.gameObject.GetComponentInChildren<SphereCollider>().radius;

            SpawnCoins(coinRadius);

            ShowFinalMessage();
        }

        private void SpawnCoins(float coinRadius)
        {
            for (int i = 0; i < _coinCount; i++)
            {
                float spawnPositionX = Random.Range(_minAxisPositionX, _maxAxisPositionX);
                float spawnPositionY = Random.Range(_minAxisPositionY, _maxAxisPositionY);
                Vector3 spawnPosition = new Vector3(spawnPositionX, 0, spawnPositionY);

                Vector3 spawnPoint = transform.position + spawnPosition;

                Vector3 checkPointPosition = new Vector3(spawnPoint.x, coinRadius, spawnPoint.z);

                if (Physics.OverlapSphere(checkPointPosition, coinRadius).Length == 1)
                {
                    Instantiate(_coinPrefab, spawnPoint, Quaternion.identity);

                    _spawnedCoinValue++;
                }
            }
        }

        private void ShowFinalMessage()
        {
            if (_coinCount > _spawnedCoinValue)
                Debug.Log($"¬ этот раз, на поле указанного размера поместилось {_spawnedCoinValue} монет из {_coinCount}");
            else
                Debug.Log($"¬се {_coinCount} монет поместились на поле");
        }
    }
}