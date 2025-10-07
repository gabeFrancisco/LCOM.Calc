using System.Text.Json;

namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            var result = Display.InputValues();
            decimal value = Calculator.Calculate(result);
            Display.PrintLCOM(value);
        }
    }

}
