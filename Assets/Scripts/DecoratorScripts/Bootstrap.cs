using UnityEngine;

namespace DecoratorScripts
{
    public class Bootstrap : MonoBehaviour
    {        
        [SerializeField] private RaceType _race = RaceType.Orc;
        [SerializeField] private Specialization _specialization = Specialization.Mage;
        
        private void Awake()
        {
            new Player(_race, _specialization);
        }
    }
}
