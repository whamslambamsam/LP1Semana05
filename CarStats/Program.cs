using System;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Bogus.Randomizer.Seed = new Random(int.Parse(args[0])); // Definir seed.
            Bogus.Faker faker = new Faker<bc>(); // Usar o objeto faker para gerar dados. 
        }
        public BarChart bc = new BarChart()
        {
            bc.AddItem("Dacia", 12),
            bc.AddItem("Ferrari", 14),
            bc.AddItem("Smart", 4),
            bc.AddItem("Lamborghini", 4),
            bc.AddItem("Ford", 7),
        };
    }
}
