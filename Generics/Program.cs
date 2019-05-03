using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            string[] strings = ArrayCreator.Create(5, "Peshko");
            int[] integers = ArrayCreator.Create(2, 3);
            Box<string> box = new Box<string>();

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                box.Add(line);
            }

            //int[] indexes = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int firstIndex = indexes[0];
            //int secoundIndex = indexes[1];

            //Swap(box.Data, firstIndex, secoundIndex);

            //Console.WriteLine(box);

            string element = Console.ReadLine();

            int count = GetCountOfGreaterElements(box.Data, element);

            Console.WriteLine(count);

        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T element) where T : IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }


            return count;
        }

        public static void Swap<T>(List<T> listWithData, int firstIndex, int secoundIndex)
        {
            T temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secoundIndex];
            listWithData[secoundIndex] = temp;
        }
    }
}
