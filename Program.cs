using System.Text.Json;

namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            var props = new ClassProps(4, 5, [1,3,2,5]);

            decimal value = Calculator.Calculate(props);
            var result = Display.InputValues();
            Console.WriteLine(JsonSerializer.Serialize(result));
            Display.PrintLCOM(value);
        }
    }

}
