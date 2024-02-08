using UnityEngine;

namespace Visitor
{
    public class Elf : Enemy
    {
        [SerializeField] private int _score = 10;
        [SerializeField] private int _weight = 65;

        public int Score => _score;
        public int Weight => _weight;
    }
}
