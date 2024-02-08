using UnityEngine;

namespace Visitor
{
    public class Human: Enemy
    {
        [SerializeField] private int _score = 5;
        [SerializeField] private int _weight = 75;

        public int Score => _score;
        public int Weight => _weight;
    }
}
