using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("Please enter the number you want to search(1-15): ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value found at Index:  " + BinarySearchNumbers(numbers, searchNumber));
            Console.ReadKey();
        }

        public static int BinarySearchNumbers(int [] numbers, int searchValue)
        {
            int midNumber;
            int leftNumber = 0;
            int rightNumber = numbers.Length - 1;

            while( leftNumber <= rightNumber)
            {
                midNumber = leftNumber + ((rightNumber - leftNumber) / 2);
                
                if(numbers[midNumber]== searchValue)
                {
                    return midNumber;
                }
                else
                {
                    if(numbers[midNumber] > searchValue)
                    {
                        rightNumber = midNumber - 1;
                    }
                    else
                    {
                        leftNumber = midNumber + 1;
                    }
                }
            }
            return -1;
        }
    }
}
