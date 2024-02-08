using System;

namespace Visitor
{
    public interface IEnemySpawnAndDeathNotifier
    {
        event Action<Enemy> SpawnNotified;
        event Action<Enemy> DeathNotified;
    }
}