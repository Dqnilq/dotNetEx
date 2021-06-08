using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class PersonalName
    {

        public PersonalName(Name firstName, Name lastName, Name fatherName) {
            if (firstName == null) {
                throw new ArgumentNullException(nameof(firstName));
            }
            if (lastName == null) {
                throw new ArgumentNullException(nameof(lastName));
            }
            if (lastName == null) {
                throw new ArgumentNullException(nameof(lastName));
            }

            FatherName = fatherName;
            FirstName = firstName;
            LastName = lastName;
        }

        public Name FirstName { get; set; }
        public Name LastName { get; set; }
        public Name FatherName { get; set; }

        public String FullName => $"{FirstName} {LastName} {FatherName}";

        public override Boolean Equals(Object obj) {
            return obj is PersonalName personalName &&
                   EqualityComparer<Name>.Default.Equals(FirstName, personalName.FirstName) &&
                   EqualityComparer<Name>.Default.Equals(LastName, personalName.LastName);
        }

        public override Int32 GetHashCode() {
            return HashCode.Combine(FirstName, LastName, FatherName);
        }

        public override String ToString() {
            return FullName;
        }
        
    }
}