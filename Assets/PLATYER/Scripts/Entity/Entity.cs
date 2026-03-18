using UnityEngine;

namespace PLATYER
{
    public class EntityBase : MonoBehaviour
    {
    
    }

    public class Entity<T> : EntityBase where T : Entity<T>
    {
        public EntityStateManager<T> states { get; protected set; }    // 状态管理器
    }

}