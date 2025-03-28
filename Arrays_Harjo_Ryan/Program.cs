using System.Diagnostics.CodeAnalysis;

namespace Arrays_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input the number of elements in the array
            Console.WriteLine("Enter the number of elements you want to store in the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());  // Get the size of the array from the user and convert it to an integer
            int[] numbers = new int[arraySize];  // Create an array of integers with the size given by the user
            int sum = 0;   // Initialize the sum of the elements in the array to 0

            for (int i = 0; i < numbers.Length; i++)    // Loop through the array and ask the user to input a number for each element
            {
                Console.WriteLine($"Enter a whole number to add to the array. ");    // Ask the user to input a number
                numbers[i] = Convert.ToInt32(Console.ReadLine());   // Get the number from the user and convert it to an integer
                sum += numbers[i];     // Add the current number to the sum
            }

            Console.WriteLine($"The sum of all elements in the array is {sum}\n");   // Print the sum of all elements in the array
            Array.Sort(numbers);    // Sort the array in ascending order
            Console.WriteLine("The sorted array in ascending order is:");   // Output the sorted array

            foreach (int number in numbers)      // Loop through the sorted array and print each number                  
            {
                Console.WriteLine(number);
            }
        }
    }
}
