using System;
using System.Configuration;
using System.Reflection;
using System.Reflection;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        public static void OperatorInfo()
        {
            Console.WriteLine("Operator: ");
            //app.conf key op
            Console.WriteLine(ConfigurationManager.AppSettings["Name"]);
            Console.WriteLine();
            
            Console.WriteLine("Потребительский кредит - 1 \n" +
                              "Недвижимость - 2 \n" +
                              "Перекредитование - 3 \n");
            Console.WriteLine();
        }

        public static int Points(Person person)
        {
            int count = 0;

            count = PointEarning.AgePoint(person)
                    + PointEarning.AmountPoint(person)
                    + PointEarning.ConvictionPoint(person)
                    + PointEarning.EmploymentPoint(person)
                    + PointEarning.PledgePoint(person)
                    + PointEarning.PurpsosePoint(person)
                    + PointEarning.AnotherCreditPoint(person);

            return count;
        }
        
        static void Main(string[] args)
        { 
            OperatorInfo();
            
            Person person = 
                new Person(new PersonalName(new Name("Данила"), new Name("Макаров"), new Name("Вячеславович")), 
                    new Age(30), 
                    new Passport(new Series("4212"), new Number("521012"), "Отделом МВД России", new DateTime(2014, 2, 19), "Академика Павлова 19"), 
                    false, 
                    new CreditAmount(10000), 
                    new Purpose(Convert.ToInt32(Console.ReadLine())), 
                    new Employment(
                        Convert.ToInt32(Console.ReadLine())),
                    new Pledge(Convert.ToInt32(Console.ReadLine())),
                    false);
            
            Console.WriteLine("Points: {0} ", Points(person));
            PointEarning.Percent(Points(person));







        }
    }
}