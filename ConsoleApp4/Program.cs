using System;

namespace ConsoleApp4

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Да се създаде конзолно приложение на С#, с което се дефинира
            //  едномерен масив от n реални елемента с двойна точност.Да се въведат
            //  стoйности на елементите и се изведат в прав и обратен ред. Да се
            //изведат поотделно елементите с четен и нечетен индекс.
            //Упътване: Където е възможно да се използва конструкция foreach вместо
            //конструкция for

            //  string command = "";
            //  Console.WriteLine("How big is the array?");
            //  int n = int.Parse(Console.ReadLine());
            // int[] Array = new int[n];
            //  for (int i = 0; i < n; i++)
            // {
            //      Array[i] = int.Parse(Console.ReadLine());
            // }
            //  Console.WriteLine(string.Join(",", Array));
            // for (int i = n-1;i >= n; i--)
            // {
            //   Console.WriteLine(Array[i] - 1);
            // }


            // 2. Да се създаде конзолно приложение на С#, с което се дефинира
            //  едномерен масив от n целочислени елемента. Да се въведат стойности
            //на елементите и да се създаде втори масив, в който да се копират само
            //положителните елементи от първия масив. Да се изведат на екрана и
            //двата масива.

            //   string command = "";
            //   Console.WriteLine("How big is the array?");
            //  int n = int.Parse(Console.ReadLine());
            // int[] Array = new int[n];
            //int[] Array2 = new int[n];

            //for (int i = 0; i < n; i++)
            //  {
            //    Console.WriteLine("number :");
            //    Array[i] = int.Parse(Console.ReadLine());

            //  if (Array[i] > 0)
            //  {
            //      Console.WriteLine("poss numbers:");
            //    }
            //   else
            //         {
            //     Console.WriteLine("neg numbers:");
            //  }
            //   }


            //3. Да се дефинира двумерен масив от имената на месеците и броя на
            //  дните във всеки месец. Да се изведе информация всеки месец какъв
            // брой дни има


            string[,] monthsArray = {
            {"Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември"},
            {"31", "28/29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31"}
        };


            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{monthsArray[0, i]} ima {monthsArray[1, i]} dni.");
            }
        }
    }
}

