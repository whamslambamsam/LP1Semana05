using System;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BarChart bc = new BarChart();

            Randomizer.Seed = new Random(int.Parse(args[0])); // Definir seed.
            Faker faker = new Faker(); // Usar o objeto faker para gerar dados. 
        }
    }
}
