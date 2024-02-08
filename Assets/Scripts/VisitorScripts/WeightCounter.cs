using System;
using UnityEngine;

namespace Visitor
{
    public class WeightCounter : IDisposable
    {
        private IEnemySpawnAndDeathNotifier _enemySpawnedNotifier;
        private EnemyVisitor _enemyVisitor;
        private int _maxEnemiesWeight;

        public WeightCounter(IEnemySpawnAndDeathNotifier enemySpawnedNotifier, int maxEnemiesWeight)
        {
            _enemySpawnedNotifier = enemySpawnedNotifier;
            _maxEnemiesWeight = maxEnemiesWeight;

            _enemySpawnedNotifier.SpawnNotified += OnEnemySpawned;
            _enemySpawnedNotifier.DeathNotified += OnEnemyKilled;

            _enemyVisitor = new EnemyVisitor();
        }

        public int EnemyWheight => _enemyVisitor.Weight;

        public bool CanEnemyAdded => _maxEnemiesWeight >= PreviousTotalWheight + EnemyWheight;

        public int PreviousTotalWheight { get; set; }

        public int TotalWheight { get; private set; }

        public void Dispose()
        {
            _enemySpawnedNotifier.SpawnNotified -= OnEnemySpawned;
            _enemySpawnedNotifier.DeathNotified -= OnEnemyKilled;
        }

        private void OnEnemySpawned(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);

            if (CanEnemyAdded)
            {
                TotalWheight += EnemyWheight;

                Debug.Log($"Вес нового врага {enemy.GetType()}: {EnemyWheight}");
                Debug.Log($"Общий вес: {TotalWheight}");
            }
        }

        private void OnEnemyKilled(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            TotalWheight -= EnemyWheight;

            Debug.Log($"Вес убитого {enemy.GetType()}: {EnemyWheight}");
            Debug.Log($"Общий вес: {TotalWheight}");
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Weight { get; private set; }

            public void Visit(Ork ork) => Weight = ork.Weight;

            public void Visit(Human human) => Weight = human.Weight;

            public void Visit(Elf elf) => Weight = elf.Weight;

            public void Visit(Robot robot) => Weight = robot.Weight;

            public void Visit(Enemy enemy) => Visit((dynamic)enemy);
        }
    }
}