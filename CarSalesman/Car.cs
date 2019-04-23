using System;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private const string defaultValueString = "n/a";
        private const double defaultValueDouble = -1; 

        public Car(string model, Engine engine, double weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight) : this(model, engine, weight, defaultValueString) { }

        public Car(string model, Engine engine, string color) : this(model, engine, defaultValueDouble, color) { }

        public Car(string model, Engine engine) : this(model, engine, defaultValueDouble, defaultValueString) { }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Model}");
            stringBuilder.AppendLine($"  {this.Engine}");
            stringBuilder.AppendLine(this.Weight == -1 ? $"  Weight : n/a" : $"  Weight: {this.Weight}");
            stringBuilder.AppendLine($"  Color: {this.Color}");

            return stringBuilder.ToString();
        }
    }
}