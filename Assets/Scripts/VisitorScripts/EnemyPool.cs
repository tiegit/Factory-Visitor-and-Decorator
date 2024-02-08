using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Visitor
{
    public class EnemyPool : IEnemySpawnAndDeathNotifier, IEnemyDeathNotifier
    {
        public event Action<Enemy> SpawnNotified;
        public event Action<Enemy> DeathNotified;

        private List<Enemy> _spawnedEnemies = new List<Enemy>();
        public WeightCounter _weigthCounter;

        private int _maxEnemiesWeight;

        public EnemyPool(int maxEnemiesWeight)
        {
            _maxEnemiesWeight = maxEnemiesWeight;
            
            _weigthCounter = new WeightCounter(this, _maxEnemiesWeight);

            new Score(this);
        }

        public WeightCounter WeightCounter => _weigthCounter;
        public bool CanEnemyAdded { get; private set; }

        public bool TryToAdd(Enemy enemy)
        {
            SpawnNotified?.Invoke(enemy);

            if (_weigthCounter.CanEnemyAdded)
            {
                _spawnedEnemies.Add(enemy);            
                 enemy.Died += OnEnemyDied;
                return true;
            }
            else 
                return false;
        }

        public int GetCount() => _spawnedEnemies.Count;

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count > 0)
            {
                _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Died -= OnEnemyDied;
            DeathNotified?.Invoke(enemy);
            _spawnedEnemies.Remove(enemy);
        }
    }
}
