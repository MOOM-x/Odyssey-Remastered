using UnityEngine;

namespace  PLATYER
{
    public abstract class EntityStateManager:MonoBehaviour
    {
        public EntityStateManagerEvents events;
    }

    public abstract class EntityStateManager<T> : EntityStateManager where T : Entity<T>
    {
        
    }
}