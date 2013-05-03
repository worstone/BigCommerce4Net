using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigCommerce4Net.Domain
{
    public class Entity<TEntity> where TEntity : Entity<TEntity>
    {
        private int? oldHashCode;
        public Guid Id { get; set; }
        public bool Equals(Entity<TEntity> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Id, Id);
        }
        public override int GetHashCode()
        {
            // Once we have a hash code we'll never change it
            if (oldHashCode.HasValue)
                return oldHashCode.Value;
            var thisIsTransient = Equals(Id, Guid.Empty);
            // When this instance is transient, we use the base GetHashCode()
            // and remember it, so an instance can NEVER change its hash code.
            if (thisIsTransient)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var other = obj as TEntity;
            if (other == null)
                return false;
            // handle the case of comparing two NEW objects
            var otherIsTransient = Equals(other.Id, Guid.Empty);
            var thisIsTransient = Equals(Id, Guid.Empty);
            if (otherIsTransient && thisIsTransient)
                return ReferenceEquals(other, this);
            return other.Id.Equals(Id);
        }
    }
}
