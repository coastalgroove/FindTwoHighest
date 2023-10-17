using System;



namespace FindTwoHighest
{
    class MainClass
    {

        public static int[] FindTwoHighest(int[] arr)
        {
            int num1 = int.MinValue;
            int num2 = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num1)
                {
                    num2 = num1;   // replace num2 with num1
                    num1 = arr[i]; // Update num1 with higher value
                }
                else if (arr[i] > num2 && arr[i] < num1)
                {
                    num2 = arr[i]; // Update num2 
                }
            }

            return new int[] { num1, num2 };
        }//end method

        static void Main()
        {
            var testResult = FindTwoHighest(new int[] { 1, 2, 2, 2, 3, 3 });
            PrintTest(testResult, "[3, 2]");
            testResult = FindTwoHighest(new int[] { 3, 4, 5, 2, 4, 5, 10 });
            PrintTest(testResult, "[10, 5]");
            testResult = FindTwoHighest(new int[] { -1, 0, 3, 0, 3, 0 });
            PrintTest(testResult, "[3, 0]");
            testResult = FindTwoHighest(new int[] { 1, 2, 2, 2, 3, 3 });
            PrintTest(testResult, "[3, 2]");
        }

        public static void PrintTest(int[] arr, string expected)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i <= arr.Length - 2)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]   Expected: ");
            Console.WriteLine(expected);
        }//Main

    }//class
}//namespace