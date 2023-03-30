using System;


namespace ArrayReversal
{
    internal class Program
    {
        static void GenerateRandomIntegers(int[] intArray, int length)
        {// The rand() is a Lib function to generate a constant set of random Integers
            Random r = new Random();
            for (int k = 0; k < length; k++)
                intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 100
        }

        static void DisplayArray(int[] intArray, int length)
        {
            for (int k = 0; k < length; k++)
                Console.Write("{0}, ", intArray[k]);
            Console.WriteLine();

        }

        static void ArrayReversal(int[] intArray, int length)
        {

            // your code
            /* int k;
             int haftArray = length / 2; 
             for (k = 0; k < haftArray; k++)
             {
                 int tmp = intArray[k];
                 intArray[k] = intArray[length - k - 1];
                 intArray[length - k - 1] = tmp;
             }*/
            //Code from teacher
            int N = length;
            int k = 0;
            while(k < N/2)
            {
                int temp = intArray[k];
                intArray[k] = intArray[N - 1 - k];
                intArray[N - 1 - k] = temp;
                k++;

        }



        static void Main(string[] args)
        {
            int[] intArray = new int[15];
            int length;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);

            //BubbleSort(intArray, length);
            ArrayReversal(intArray, length);
            Console.WriteLine("The reversed array:");
            DisplayArray(intArray, length);
            Console.ReadKey();

        }
    }
}