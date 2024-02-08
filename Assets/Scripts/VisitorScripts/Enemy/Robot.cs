using UnityEngine;

namespace Visitor
{
    public class Robot : Enemy
    {
        [SerializeField] private int _score = 5;
        [SerializeField] private int _weight = 25;

        public int Score => _score;
        public int Weight => _weight;
    }
}
