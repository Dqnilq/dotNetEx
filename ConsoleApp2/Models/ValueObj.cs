using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public abstract class ValueObject : IValidator
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;

            return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
        public static Boolean IsValid(String value) {
            return !String.IsNullOrWhiteSpace(value);
        }
    }
}