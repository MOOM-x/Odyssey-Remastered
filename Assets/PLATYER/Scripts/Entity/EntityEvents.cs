using System;
using UnityEngine.Events;

namespace  PLATYER
{
    
    [Serializable]
    public class EntityEvents
    {
        public UnityEvent OnEntityCreated;
        public UnityEvent OnGroundExit;
    }
}