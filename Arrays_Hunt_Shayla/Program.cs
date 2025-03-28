namespace Arrays_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input the number of elements to be stored in the array.
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            // Ask the user to input values for all the array elements specified by user.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            // Displays the sum of all the numbers in the array.
            Console.WriteLine($"The sum of the array is {sum}");

            // Sorts the array in ascending order
            Array.Sort(numbers);

            // Displays the sorted array.
            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
