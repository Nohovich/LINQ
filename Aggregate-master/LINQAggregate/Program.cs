using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int smallestNumber = Numbers.Min();
            Console.WriteLine("Smallest Number = " + smallestNumber);

            int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();
            Console.WriteLine("Smallest Even Number = " + smallestEvenNumber);

            int largestNumber = Numbers.Max();
            Console.WriteLine("Largest Number = " + largestNumber);
            
            int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();
            Console.WriteLine("Largest Even Number = " + largestEvenNumber);
           
            int sumOfAllNumbers = Numbers.Sum();
            Console.WriteLine("Sum of All Numbers = " + sumOfAllNumbers);
           
            int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine("Sum of All Even Numbers = " + sumOfAllEvenNumbers);

            int countOfAllNumbers = Numbers.Count();
            Console.WriteLine("Count of All Numbers = " + countOfAllNumbers);
            
            int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();
            Console.WriteLine("Count of All Even Numbers = " + countOfAllEvenNumbers);

            double averageOfAllNumbers = Numbers.Average();
            Console.WriteLine("Average of All Numbers = " + averageOfAllNumbers);
           
            double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();
            Console.WriteLine("Average of All Even Numbers = " + averageOfAllEvenNumbers);

            string[] countries = { "India", "USA", "UK" };

            int minCount = countries.Min(x => x.Length);
            Console.WriteLine
                  ("The shortest country name has {0} characters in its name", minCount);

            int maxCount = countries.Max(x => x.Length);
            Console.WriteLine
                   ("The longest country name has {0} characters in its name", maxCount);

            string result = countries.Aggregate((a, b) => a + ", " + b);
            // Step 1.First "India" is concatenated with "US" to produce result "India, US"
            // Step 2.Result in Step 1 is then concatenated with "UK" to produce result "India, US
            // This goes on until the last element in the array to produce the final single string
            Console.WriteLine(result);

            int resultInt = Numbers.Aggregate((a, b) => a * b);
            // Step 1: Multiply(1X2) to produce result 2
            // Step 2: Result(2) in Step 1 is then multiplied with 2(2X3) to produce result 6
            Console.WriteLine(result);

             resultInt = Numbers.Aggregate(10, (a, b) => a * b);
            // Step 1: Multiply (10X1) to produce result 10
            // Step 2: Result(10) in Step 1 is then multiplied with 2(10X2) to produce result 20
            Console.ReadKey();
        }
    }
}
