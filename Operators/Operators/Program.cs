using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double mealCost = 1;
            int tipPercent =  1;
            int taxPercent =  1;

            Console.WriteLine("Please enter meal cost");
            mealCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("meat cost=" + mealCost);

            Console.WriteLine("Please enter tip percent");
            tipPercent = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("tip percent=" + tipPercent);

            Console.WriteLine("Please enter tax percent");
            taxPercent = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("tax percent=" + taxPercent);


            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            int totalCost = (int)Convert.ToInt64(tip + tax + mealCost);
           

            Console.WriteLine("Total cost = " + totalCost);





        }
    }
}
