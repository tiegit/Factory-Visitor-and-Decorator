using UnityEngine;

namespace Visitor
{
    public class Ork : Enemy
    {
        [SerializeField] private int _score = 20;
        [SerializeField] private int _weight = 140;

        public int Score => _score;
        public int Weight => _weight;
    }
}
