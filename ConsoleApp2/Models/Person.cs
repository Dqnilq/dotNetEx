using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Person 
    {
        public Person(PersonalName personalName, Age age, Passport passport, bool conviction, CreditAmount creditAmount, Purpose purpose, Employment employment, Pledge pledge, bool anotherCredits) {
            if (personalName == null) {
                throw new ArgumentNullException(nameof(personalName));
            }
            if (age == null) {
                throw new ArgumentNullException(nameof(age));
            }

            Id = Guid.NewGuid();
            PersonalName= personalName;
            Age = age;
            Passport = passport;
            Conviction = conviction;
            Amount = creditAmount;
            Purpose = purpose;
            Employment = employment;
            Pledge = pledge;
            AnotherCredits = anotherCredits;
        }

        public Person()
        {
            
        }

        public Guid Id { get; private set; }
        public PersonalName PersonalName{ get; set; }
        public Age Age { get; set; }
        
        public Passport Passport { get; set; }
        
        public bool Conviction { get; set; }
        
        public CreditAmount Amount { get; set; }
        
        public Purpose Purpose { get; set; }
        
        public Employment Employment { get; set; }
        
        public Pledge Pledge { get; set; }
        
        public bool AnotherCredits { get; set; }
        
    }
    
}