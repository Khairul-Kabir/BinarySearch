using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 2,7,8,9,13,19,21};
            //binarySearch(numArray, 7);
            Console.WriteLine("This is your arry: ");
            foreach (var item in numArray)
            {
                Console.Write(item+",");
            }
            Console.WriteLine("\n"+binarySearch(numArray, 7));
            Console.WriteLine(binarySearch(numArray, 13));
        }
        public static dynamic binarySearch(int[] numArray, int target)
        {
            int left = 0;
            int right = numArray.Length - 1;
            while (left < right)
            {
                int mid = Convert.ToInt32((left+right)/2);
                if (target == numArray[mid])
                {
                    return mid;
                }else if (target<numArray[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
