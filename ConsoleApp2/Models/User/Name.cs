using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    public class Name : ValueObject
    {
        private static readonly Regex ValidationRegex = new Regex(
            @"^[\p{L}\p{M}\p{N}]{1,100}\z",
            RegexOptions.Singleline | RegexOptions.Compiled);

        public Name(String value) {
            if (!IsValid(value)) {
                throw new ArgumentException("Name is not valid");
            }

            Value = value;
        }

        public String Value { get; set; }

        public static Boolean IsValid(String value) {
            return !String.IsNullOrWhiteSpace(value) && ValidationRegex.IsMatch(value);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals(Object obj) {
            return obj is Name other &&
                   StringComparer.Ordinal.Equals(Value, other.Value);
        }

        public override Int32 GetHashCode() {
            return StringComparer.Ordinal.GetHashCode(Value);
        }
    }
}