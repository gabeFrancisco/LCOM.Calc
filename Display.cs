using System.Text.Json;

namespace LCOM.Calc
{
    public class Display
    {
        public static void PrintLCOM(decimal value)
        {
            Console.WriteLine($"\nThe result of LCOM equation is: {value.ToString("f2")}\n");
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