# Day-2-Operators
Day-2-Operators

<img width="573" alt="Ekran Resmi 2022-05-19 15 19 53" src="https://user-images.githubusercontent.com/105243448/169291734-2e0039a3-a28e-4069-b8b8-8a5e61550b06.png">







```
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


```

<img width="924" alt="Ekran Resmi 2022-05-19 15 12 44" src="https://user-images.githubusercontent.com/105243448/169291869-c9a71f03-e056-4db9-bd82-d55731f1c17b.png">




