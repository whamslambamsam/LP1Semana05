using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Reflection;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var image = new CanvasImage(args[0]);
            image.MaxWidth(args[1]);
            
            if (args[0] == "" | args[1] == "")
            {
                image = "tux.jpg";
                Image.MaxWidth(24);
            }
            AnsiConsole.Write(image);
        }
    }
}
