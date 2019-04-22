using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            //Practice inputing values in different ways
            /*
            int input;
            Console.WriteLine("Enter a value: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{input}"+" "+$"{input}"+ " "+ $"{input}"+ " "+$"{input}");
            Console.WriteLine($"{input}"+$"{input}"+$"{input}"+$"{input}");
            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);


          7.//Check number value, provide input depending on value given
            /*
            start:
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("You may enter the bar and have a drink");
                goto start;
            }
            else if (age < 21)
            {
                Console.WriteLine("Sorry little guy. Come back when you're older.");
                goto start;
            }

          6.//Find the average of 4 numbers
            /*
            Console.Write("Enter the first number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double input3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            double avg = (input1 + input2 + input3 + input4) / 4;
            Console.WriteLine("Average of 4 numbers: {0} + {1} + {2} + {3} = {4}",
                input1, input2, input3, input4, avg);

          5.//Create a multiplication table
            /*
            Console.Write("Provide an integer value to create a multiplication table for: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input * 0);
            Console.WriteLine(input * 1);
            Console.WriteLine(input * 2);
            Console.WriteLine(input * 3);
            Console.WriteLine(input * 4);
            Console.WriteLine(input * 5);
            Console.WriteLine(input * 6);
            Console.WriteLine(input * 7);
            Console.WriteLine(input * 8);
            Console.WriteLine(input * 9);
            Console.WriteLine(input * 10);

          4.//Different operations to the same values
            /*
            int num1, num2;

            Console.WriteLine("Input the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

          3.//Take 3 values and multiply them by each other to get a result
            /*
            int firstInput, secondInput, thirdInput;

            Console.Write("Input the first number to multiply: ");
            firstInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdInput = Convert.ToInt32(Console.ReadLine());

            int result = firstInput * secondInput * thirdInput;
            Console.WriteLine("Result: {0} x {1} x {2} = {3}",
                                        firstInput, secondInput, thirdInput, result);
            

          2.//Swapping Number Values
            /*int number1, number2, second;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            second = number1;
            number1 = number2;
            number2 = second;
            Console.Write("\nAfter Swapping");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();

          1.//Simple Division
            /*Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 /11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);*/
        }
    }
}
