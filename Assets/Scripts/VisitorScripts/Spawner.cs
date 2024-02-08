using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Visitor
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;
        
        private EnemyPool _enemyPool;
        private Coroutine _spawn;
        private int _maxEnemiesWeight;

        public void StartWork(int maxEnemiesWeight)
        {
            _maxEnemiesWeight = maxEnemiesWeight;

            _enemyPool = new EnemyPool(_maxEnemiesWeight);

            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        public void KillRandomEnemy()
        {
            if (_enemyPool.GetCount() == 0)
                return;

            _enemyPool.KillRandomEnemy();
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));

                bool isEnemyAdded = _enemyPool.TryToAdd(enemy);

                if (isEnemyAdded)
                {
                    _enemyPool._weigthCounter.PreviousTotalWheight = _enemyPool._weigthCounter.TotalWheight;

                    MoveToPoint(enemy);
                    yield return new WaitForSeconds(_spawnCooldown);
                }
                else
                {
                    _enemyPool._weigthCounter.PreviousTotalWheight = _enemyPool._weigthCounter.TotalWheight;

                    Destroy(enemy.gameObject);
                    yield return new WaitForFixedUpdate();
                }                
            }
        }

        private void MoveToPoint(Enemy enemy)
        {
            Transform randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

            enemy.MoveTo(randomPoint.position);
        }    
    }
}
