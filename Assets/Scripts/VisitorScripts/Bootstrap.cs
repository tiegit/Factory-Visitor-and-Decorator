using UnityEngine;

namespace Visitor
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private int _maxEnemiesWeight = 1000;

        private void Awake() => _spawner.StartWork(_maxEnemiesWeight);

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) _spawner.KillRandomEnemy();            
        }
    }
}
