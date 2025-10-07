using System.Text.Json;

namespace LCOM.Calc
{
    public class Display
    {
        public static void PrintLCOM(decimal value)
        {
            Console.WriteLine($"\nThe result of LCOM equation is: {value}\n");
        }

        public static dynamic InputValues()
        {
            int attributes, methods;

            Console.Write("Enter the number of attributes: ");
            attributes = int.Parse(Console.ReadLine()!);

            Console.Write("\nEnter the number of methods: ");
            methods = int.Parse(Console.ReadLine()!);

            int[] attributesInMethods = new int[attributes];
            Console.WriteLine(JsonSerializer.Serialize(attributesInMethods));

            for (int i = 0; i < attributes; i++)
            {
                Console.Write($"\nAttribute n#{i + 1} appears in how many methods?");
                attributesInMethods[i] = int.Parse(Console.ReadLine()!);
            }

            return new
            {
                attributes,
                methods,
                attributesInMethods
            };
        }
    }
}