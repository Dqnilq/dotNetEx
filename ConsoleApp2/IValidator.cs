using System;

namespace ConsoleApp2
{
    public interface IValidator
    {
        public static Boolean IsValid(String value) {
            return !String.IsNullOrWhiteSpace(value);
        }
        
        
    }
}