using System;
using UnityEngine.Events;
namespace  PLATYER
{
     [Serializable]
    public class EntityStateManagerEvents
    {
        public UnityEvent OnChange;
        public UnityEvent<Type> onEnter;
        public UnityEvent<Type> onExit;
    }
}