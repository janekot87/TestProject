using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class MetodsFunctions
    {
        public static void Main()
        {
            SayHello();
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Multiply(num1,num2);
            int result = Add(num1, num2);
            Console.WriteLine("Result of addition is " + result);

            Console.ReadKey();

        }
        public static void SayHello()
        {
            Console.WriteLine("Hello Jane!");
        }
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine("Result of multiplication is " + num1 * num2);
        }
        public static int Add(int num1, int num2) {
            return num1 + num2;
       
        }
    }
}
