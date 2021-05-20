using System;
using uScript.API.Attributes;

namespace MixyConsoleModule
{
    [ScriptModule("console")]
    public class ConsoleModule
    {
        [ScriptFunction(null)]
        public static void Write(string message, string consoleColor = null)
        {
            var color = ConsoleColor.White;
            if (consoleColor == null)
            {
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
                return;
            }
            if (consoleColor == "red")
            {
                color = ConsoleColor.Red;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "yellow")
            {
                color = ConsoleColor.Yellow;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "cyan")
            {
                color = ConsoleColor.Cyan;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "magenta")
            {
                color = ConsoleColor.Magenta;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "gray")
            {
                color = ConsoleColor.Gray;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "blue")
            {
                color = ConsoleColor.Blue;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "green")
            {
                color = ConsoleColor.Green;
                Console.Write(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else
            {
                color = ConsoleColor.Red;
                Console.Write("uScript => Color not found.", Console.ForegroundColor = color);
                Console.Write("uScript => Available colors : green - red - yellow - cyan - magenta - gray - blue");
                Console.ResetColor();
            }
        }
        [ScriptFunction(null)]
        public static void WriteLine(string message, string consoleColor = null)
        {
            var color = ConsoleColor.White;
            if (consoleColor == null)
            {
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
                return;
            }
            if (consoleColor == "red")
            {
                color = ConsoleColor.Red;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "yellow")
            {
                color = ConsoleColor.Yellow;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "cyan")
            {
                color = ConsoleColor.Cyan;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "magenta")
            {
                color = ConsoleColor.Magenta;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "gray")
            {
                color = ConsoleColor.Gray;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "blue")
            {
                color = ConsoleColor.Blue;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else if (consoleColor == "green")
            {
                color = ConsoleColor.Green;
                Console.WriteLine(message, Console.ForegroundColor = color);
                Console.ResetColor();
            }
            else
            {
                color = ConsoleColor.Red;
                Console.WriteLine("uScript => Color not found.", Console.ForegroundColor = color);
                Console.WriteLine("uScript => Available colors : green - red - yellow - cyan - magenta - gray - blue");
                Console.ResetColor();
            }
        }
    }
}
