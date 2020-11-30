using System;

namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    [Serializable]
    public abstract class Entity : Entity<int>, IEntity
    {
        public Entity()
        {
        }
        public Entity(int id)
            : base(id)
        {
        }
    }

    [Serializable]
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
        public Entity()
        {
        }
        public Entity(TPrimaryKey id)
        {
            Id = id;
        }
    }
}
