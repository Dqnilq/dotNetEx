using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp2
{
    public class PointEarning  : Person 
    {
        
        public PointEarning()
        {
            
        }
        
        public static int AgePoint(Person person)
        {
            if (person.Age.Value >= 21 && person.Age.Value <= 28)
            {
                if (person.Amount.Value < 1000000)
                    return 12;

                if (person.Amount.Value >= 1000000 && person.Amount.Value <= 3000000)
                    return 9;

                if (person.Amount.Value >= 3000000)
                    return 0;
            }

            if (person.Age.Value >= 29 && person.Age.Value <= 60)
                return 14;
            
            if (person.Age.Value >= 60 && person.Age.Value <= 72)
                if (person.Pledge != null)
                    return 8;
                else
                    return 0;
            return 0;
        }

        public static int ConvictionPoint(Person person)
        {
            if (person.Conviction == true)
                return 0;
            return 15;
        }

        public static int EmploymentPoint(Person person)
        {
            Dictionary<int, int> point = new Dictionary<int, int>();
            point[1] = 14;
            point[2] = 12;
            point[3] = 8;
            point[4] = 5;
            point[5] = 0;
            point[6] = 0;
            
            foreach (var i in point)
            {
                if (i.Key == person.Employment.Value)
                    return i.Value;
            }
            
            return 0;
        }

        public static int PurpsosePoint(Person person)
        {
            Dictionary<int, int> point = new Dictionary<int, int>();
            point[1] = 14;
            point[2] = 8;
            point[3] = 12;
            foreach (var i in point)
            {
                if (i.Key == person.Employment.Value)
                    return i.Value;
            }
            
            return 0;
        }
        
        public static int PledgePoint(Person person)
        {
            Dictionary<int, int> point = new Dictionary<int, int>();
            point[1] = 16;
            point[2] = 8;
            point[3] = 3;
            point[4] = 12;
            foreach (var i in point)
            {
                if (i.Key == person.Pledge.Value)
                    return i.Value;
            }
            
            return 0;
        }

        public static int AnotherCreditPoint(Person person)
        {
            if (person.AnotherCredits == false)
                return 15;
            
            return 0;
        }

        public static int AmountPoint(Person person)
        {
            if (person.Amount.Value <= 1000000)
                return 12;
            if (person.Amount.Value >= 1000001 && person.Amount.Value <= 500000)
                return 14;
            if(person.Amount.Value >= 5000001 && person.Amount.Value <= 1000000)
                return 8;
            return 0;
        }

        public static void Percent(int count)
        {
            if (count < 80)
                Console.WriteLine("Кредит не одобрен.");
            if (count == 80)
                Console.WriteLine("Ваша ставка по кредиту: 30%");
            if (count > 80 && count <= 84)
                Console.WriteLine("Ваша ставка по кредиту: 26%");
            if (count > 84 && count <= 88)
                Console.WriteLine("Ваша ставка по кредиту: 22%");
            if (count > 88 && count <= 92)
                Console.WriteLine("Ваша ставка по кредиту: 19%");
            if (count > 92 && count <= 96)
                Console.WriteLine("Ваша ставка по кредиту: 15%");
            if (count >= 96)
                Console.WriteLine("Ваша ставка по кредиту: 12,5%");
        }
        
        
    }
}