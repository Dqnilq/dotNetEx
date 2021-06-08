using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Series : ValueObject, IValidator
    {
        public Series(String value) {
            if (!IsValid(value)) {
                throw new ArgumentException("Series is not valid");
            }

            Value = value;
        }

        public String Value { get; set; }

        public static Boolean IsValid(String value) {
            return !String.IsNullOrWhiteSpace(value);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals(Object obj) {
            return obj is Series other &&
                   StringComparer.Ordinal.Equals(Value, other.Value);
        }

        public override Int32 GetHashCode() {
            return StringComparer.Ordinal.GetHashCode(Value);
        }
    }
}