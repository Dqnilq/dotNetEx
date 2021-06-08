using System;

namespace ConsoleApp2
{
    public class Age
    {
        public Age(Int32 value) {
                if (!IsValid(value)) {
                    throw new ArgumentException("Age is not valid");
                }
        
                Value = value;
            }
        
            public Int32 Value { get; set; }
        
            public static Boolean IsValid(Int32 value) {
                return 18 <= value && value <= 90;
            }
        
            public override Boolean Equals(Object obj) {
                return obj is Age other && Value == other.Value;
            }
        
            public override Int32 GetHashCode() {
                return Value.GetHashCode();
            }
    }
}