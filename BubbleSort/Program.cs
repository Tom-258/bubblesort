using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArr = new int[] {0, 3, 1, 8, 7, 2, 5, 4, 6, 9};
            for (var i = 0; i < myArr.Length; i++)
            {
                {
                    for (var j = 0; j < myArr.Length - 2; j++)
                    {
                        if (myArr[j] > myArr[j + 1])
                        {
                            var temp = myArr[j + 1];
                            myArr[j + 1] = myArr[j];
                            myArr[j] = temp;
                        }

                        foreach (var number in myArr)
                        {
                            Console.WriteLine(number);
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                    }
                }
            }
        }
    }
}