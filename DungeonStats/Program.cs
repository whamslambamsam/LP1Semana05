using System;
using System.Data;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static int Damage(int attack, int defense)
        {
            return new num = attack - defense;
        }

        private static int Damage(int attack)
        {
            return attack;
        }

        private static int CriticalHit(int damage)
        {
            
        }

        private static void Main(string[] args)
        {
            int damage = Convert.ToInt32(args[0]);
            int defense = Convert.ToInt32(args[1]);
            if (args[1] == "")
            {
                defense = 2;
            }

            var table = new Table();

            table.AddColumn("Operation");
            table.AddColumn("Result");

            table.AddRow("Damage(" + Damage(damage) + ")", $"{damage}");
            table.AddRow("Damage(" + Damage(damage) + "," + Damage(defense) + ")",
            $"{Damage(damage, defense)}");
        }
    }
}
