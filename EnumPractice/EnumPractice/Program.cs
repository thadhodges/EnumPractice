using System;

namespace EnumPractice
{
    class Program
    {
        enum Weekdays
        {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

        enum Foods
        {Chicken, Fries, Salad}


        static void Main(string[] args)
        {
            
            Console.WriteLine(Weekdays.Friday);
            Console.WriteLine(Foods.Chicken);
        }
    }
}
