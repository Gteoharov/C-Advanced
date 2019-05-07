using System;
using System.Linq;

namespace InteratorsAndComparators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ListyIterator<string> listyIterator = null;

            while (input != "END")
            {
                string[] splitedInput = input.Split(' ');
                string command = splitedInput[0];



                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(splitedInput.Skip(1).ToList());
                }
                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "PrintAll")
                {
                    foreach (var element in listyIterator)
                    {
                        Console.Write(element + " ");
                    }
                }


                input = Console.ReadLine();
            }
        }
    }
}
