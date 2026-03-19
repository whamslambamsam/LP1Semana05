using System;
using System.ComponentModel;
using System.Dynamic;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using Spectre.Console;

namespace LevelTwo
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var image = new CanvasImage(Convert.ToString($"{args[0]}"));
            image.MaxWidth(Convert.ToInt32(args[1]));

            if (args[0] == "" | args[1] == "")
            {
                image = new CanvasImage("LP1Semana05\tux.jpg");
                image.MaxWidth(24);
            }

            AnsiConsole.Write(image);
        }
    }
}
