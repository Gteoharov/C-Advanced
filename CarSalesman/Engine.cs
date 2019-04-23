using System;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private const string defaultValueString = "n/a";
        private const int defaultValueInt = -1;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, defaultValueString)
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, defaultValueInt, efficiency)
        {
        }

        public Engine(string model, int power) : this(model, power, defaultValueInt, defaultValueString)
        {
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"  {this.Model}");
            stringBuilder.AppendLine($"    Power: {this.Power}");
            stringBuilder.AppendLine(this.Displacement == -1 ? $"    Displacement: n/a" : $"    Displacement: {this.Displacement}");
            stringBuilder.AppendLine($"    Efficiency: {this.Efficiency}");

            return stringBuilder.ToString();
        }
    }
}
