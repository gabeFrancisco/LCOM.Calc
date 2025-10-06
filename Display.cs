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

            return new
            {
                attributes,
                methods
            };
        }
    }
}