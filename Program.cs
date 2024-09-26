namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   
             *   დავალება I
             *   
              int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

              int evenSum = 0;

              foreach (int num in numbers)
              {
                  if (num % 2 == 0) 
                  {
                      evenSum += num;
                  }
              }

              Console.WriteLine("sum of even numbers: " + evenSum);
            */



            /*  დალება II


          int[] sourceArray = { 1, 2, 3, 4, 5 };

          int[] destinationArray = new int[sourceArray.Length];

          for (int i = 0; i < sourceArray.Length; i++)
          {
              destinationArray[i] = sourceArray[i];
          }

          Console.WriteLine("Copied array:");
          foreach (int num in destinationArray)
          {
              Console.WriteLine(num);

          }
            */

            /*
                   დავალება IV
           
            int[] numbers = { 12, 45, 7, 89, 23, 56, 99, 34 };

            
            int maxElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }

            
            Console.WriteLine("The maximum element in the array is: " + maxElement);

            */


            /*  დავაება V
            
            int[] numbers = { 12, 45, 7, 89, 23, 56, 99, 34 };

           
            int maxElement = numbers[0];
            int maxIndex = 0;

            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                    maxIndex = i;
                }
            }

            
            Console.WriteLine("The maximum element index is: " + maxIndex);

            */







        }
    }
}
