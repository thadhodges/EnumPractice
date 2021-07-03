using System;

namespace EnumPractice
{
    class Program
    {
        enum Weekdays
        {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

        enum Foods
        {Chicken, Fries, Salad}

        enum ChickenTypes
        {Reds,
        Bantham,
        White,
        Speckled}


        static void Main(string[] args)
        {
            
            Console.WriteLine(Weekdays.Tuesday);
            Console.WriteLine(Foods.Salad);
            Console.WriteLine(ChickenTypes.Speckled);
        }
    }
}
