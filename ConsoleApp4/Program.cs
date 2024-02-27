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
            {"31", "28/29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31"} };


            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{monthsArray[0, i]} ima {monthsArray[1, i]} dni.");
            }


            // Да се създаде конзолно приложение, с което се обработват следните
            // метереологични данни: измерени са температури в дадени станции и се
            //извлича следната информация – в коя станция е измерена най-висока и в
            //коя най-ниска температура; каква е температурната разлика между двете
            //температури.Да се отчита и факта, че в повече от една станции може да
            //е измерена еднаква температура.

            Console.Write("Enter the number of weather stations: ");
            int numberOfStations = int.Parse(Console.ReadLine());

            string[] stationNames = new string[numberOfStations];
            double[] temperatures = new double[numberOfStations];

            for (int i = 0; i < numberOfStations; i++)
            {
                Console.Write($"Enter the temperature for station {i + 1}: ");
                temperatures[i] = double.Parse(Console.ReadLine());
                Console.Write($"Enter the name of station {i + 1}: ");
                stationNames[i] = Console.ReadLine();
            }

            int maxTemperatureIndex = Array.IndexOf(temperatures, temperatures.Max());
            int minTemperatureIndex = Array.IndexOf(temperatures, temperatures.Min());

            var sameTemperatureStations = Array.FindAll(temperatures, temp => temp == temperatures[maxTemperatureIndex]);

            Console.WriteLine($"Station with the highest temperature: {stationNames[maxTemperatureIndex]}, Temperature: {temperatures[maxTemperatureIndex]}");
            Console.WriteLine($"Station with the lowest temperature: {stationNames[minTemperatureIndex]}, Temperature: {temperatures[minTemperatureIndex]}");
            Console.WriteLine($"Temperature difference: {temperatures[maxTemperatureIndex] - temperatures[minTemperatureIndex]}");

            if (sameTemperatureStations.Length > 1)
            {
                Console.WriteLine("Note: Multiple stations have the same highest temperature.");
            }






        }



    }
}

