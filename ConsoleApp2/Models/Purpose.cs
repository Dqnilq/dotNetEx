using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Purpose : ValueObject
    {
        public Purpose(Int32 value)
        {
           Console.WriteLine("Трудоустроен по трудовому договору - 1 \n" + 
                                         "Собственное ИП - 2 \n"  + 
                                         "Фрилансер - 3 \n" + 
                                         "Пенсионер > 70 - 4 \n" + 
                                         "Пенсионер < 70 - 5 \n" + 
                                         "Безработный - 6 \n");
           Console.WriteLine();
            if (!IsValid(value))
            {
                throw new ArgumentException("Employment is not valid");
            }

            Value = value;
        }

        public Int32 Value { get; set; }

        public static Boolean IsValid(Int32 value)
        {
            return value != null;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals(Object obj)
        {
            return obj is Employment other && Value == other.Value;
        }

        public override Int32 GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}