using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Employment : ValueObject
    {
        public Employment(Int32 value) {
             Console.WriteLine("Недвижимость - 1\n" + 
                                                    "Автомобиль с возрастом > 3  - 2\n"  + 
                                                    "Автомобиль с возрастом < 3 - 3\n"+ 
                                                    "Поручительство - 4\n");
             Console.WriteLine();
            if (!IsValid(value)) {
                throw new ArgumentException("Employment is not valid");
            }
        
            Value = value;
        }
        
        public Int32 Value { get; set; }
        
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