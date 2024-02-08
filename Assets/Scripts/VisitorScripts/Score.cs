using System;
using UnityEngine;

namespace Visitor
{
    public class Score: IDisposable
    {
        private IEnemyDeathNotifier _enemyDeathNotifier;

        private EnemyVisitor _enemyVisitor;

        public Score(IEnemyDeathNotifier enemyDeathNotifier)
        {
            _enemyDeathNotifier = enemyDeathNotifier;
            _enemyDeathNotifier.DeathNotified += OnEnemyKilled;

            _enemyVisitor = new EnemyVisitor();
        }

        public int Value => _enemyVisitor.Score;

        public void Dispose() => _enemyDeathNotifier.DeathNotified -= OnEnemyKilled;

        private void OnEnemyKilled(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            Debug.Log($"—чет: {Value}");
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Ork ork) => Score += ork.Score;

            public void Visit(Human human) => Score += human.Score;

            public void Visit(Elf elf) => Score += elf.Score;

            public void Visit(Robot robot) => Score += robot.Score;

            public void Visit(Enemy enemy) => Visit((dynamic) enemy);
        }
    }
}
