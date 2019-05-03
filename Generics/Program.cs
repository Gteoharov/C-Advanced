using System;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());

            string[] strings = ArrayCreator.Create(5, "Peshko");
            int[] integers = ArrayCreator.Create(2, 3);

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}
