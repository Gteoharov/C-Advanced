namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineArgs = Console.ReadLine().Split(new [] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string model = engineArgs[0];
                int power = int.Parse(engineArgs[1]);

                Engine engine = null;

                if (engineArgs.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineArgs.Length == 3)
                {
                    bool isDisplacement = int.TryParse(engineArgs[2], out int displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineArgs[2]);
                    }
                } 
                else
                {
                    engine = new Engine(model, power, int.Parse(engineArgs[2]), engineArgs[3]);
                }

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string model = carArgs[0];
                string engineModel = carArgs[1];


                Engine engine = engines
                    .Where(x => x.Model == engineModel)
                    .FirstOrDefault();

                Car car = null;

                if (carArgs.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carArgs.Length == 3)
                {
                    bool isWeight = double.TryParse(carArgs[2], out double weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, carArgs[2]);
                    }
                }
                else
                {
                    car = new Car(model, engine, double.Parse(carArgs[2]), carArgs[3]);
                }
                cars.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
