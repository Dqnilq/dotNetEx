using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Pledge: ValueObject
    {
        public Int32 Value { get; set; }
        public Pledge(Int32 value) {
            
         
            if (!IsValid(value)) {
                throw new ArgumentException("Employment is not valid");
            }
        
            Value = value;
        }
        
        
        
        public static Boolean IsValid(Int32 value) {
            return value != null;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals(Object obj) {
            return obj is Employment other && Value == other.Value;
        }
        
        public override Int32 GetHashCode() {
            return Value.GetHashCode();
        }
    }
}