using System;
using System.Collections.Generic;

namespace TestProject
{
    public class ConsoleTests
    {
        public static void Main1()
        {

            /* int num, num1;

        Console.WriteLine("Enter first number:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result is " + (num + num1).ToString());
        Console.ReadKey();*/


            /* int num = 12;
              //num++;
              num /= 3;
              Console.WriteLine(num);
              Console.ReadKey();*/

            /*double num;
            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine());

            if (num >= 18 || num > 70)
                Console.WriteLine("You are allowed to play this game");
            else if (num < 6)
                Console.WriteLine("You are not allowed to play computer games");
            else
                Console.WriteLine("You are not allowed to play this game");

            string status = num == 18 ? "First" : "Second";
            Console.WriteLine(status);

            Console.ReadKey();*/



            /*Random randNum = new Random();

            int num;
            num = randNum.Next(1, 10);

            switch (num) {
                case 1:
                    Console.WriteLine("Number first " + num);
                    break;
                default:
                    Console.WriteLine("Number is " + num);
                    break;

            }
            Console.ReadKey();*/


            /* for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine(i + "\n");

             }
             Console.ReadKey();*/

            /* for (int i = 10; i >= 5; i -= 2)
             {
                 Console.WriteLine(i + "\n");
                             }
             Console.ReadKey();*/

            /* int i = 0;
             while(i<=7)
             {
                 Console.WriteLine(i + "\n");
                 i++;
             }
             Console.ReadKey();*/

            /*int number;
            do
            {
                Console.WriteLine("Enter number:");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number !=5);
            Console.ReadKey();*/

            /*for (int i = 0; i <= 10; i++)
            {
                if (i == 8)
                continue;
              Console.WriteLine(i + "\n");
            }
            Console.ReadKey();*/

            /* List<string> names = new List<string>();
             names.Add("Kolya");
             names.Add("Tolya");
             names.Add("Olya");
             names.Remove("Tolya");
             for (int i = 0; i < names.Count; i++)
                 Console.Write(names[i] + ", ");
             Console.ReadKey();*/

            /*int[] array = new int[5];
            array[0]  = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.ReadKey();*/

            /*float[] numbers = { 1.45f, 2.54f, 5.55f };
            foreach (float el in numbers)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();*/

        }
    }
}
