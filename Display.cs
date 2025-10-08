using System.Text.Json;
using Spectre.Console;

namespace LCOM.Calc
{
    public class Display
    {
        public static void PrintLCOM(decimal value)
        {
            Console.WriteLine($"\nThe result of LCOM equation is: {value.ToString("f2")}\n");
        }

        public static int OptionsMenu()
        {
            var value = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose an [green]option[/] bellow: ")
                    .PageSize(7)
                    .AddChoices(new[]{
                        "1 - Select a directory or file path",
                        "2 - Insert data manually"
                    })
            );

            return int.Parse(value[..1]);
        }

        public static ClassProps InputValues()
        {
            int attributes, methods;

            Console.Write("Enter the number of attributes: ");
            attributes = int.Parse(Console.ReadLine()!);

            Console.Write("\nEnter the number of methods: ");
            methods = int.Parse(Console.ReadLine()!);

            int[] attributesInMethods = new int[attributes];

            for (int i = 0; i < attributes; i++)
            {
                Console.Write($"\nAttribute n#{i + 1} appears in how many methods?");
                attributesInMethods[i] = int.Parse(Console.ReadLine()!);
                if (attributesInMethods[i] > methods)
                {
                    throw new IndexOutOfRangeException("You tipped an attribute count greather than the class methods number!");
                }
            }

            return new ClassProps(attributes, methods, attributesInMethods);
        }
    }
}