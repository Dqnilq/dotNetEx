using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class CreditAmount : ValueObject
    {
        public CreditAmount(Int32 value) {
            if (!IsValid(value)) {
                throw new ArgumentException("CreditAmount is not valid");
            }
        
            Value = value;
        }
        
        public Int32 Value { get; set; }
        
        public static Boolean IsValid(Int32 value) {
            return 0 <= value && value <= 10000000;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals(Object obj) {
            return obj is CreditAmount other && Value == other.Value;
        }
        
        public override Int32 GetHashCode() {
            return Value.GetHashCode();
        }
    }
}