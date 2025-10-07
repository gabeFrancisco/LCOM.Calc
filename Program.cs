namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            try
            {
                var result = Display.InputValues();
                decimal value = Calculator.Calculate(result);
                Display.PrintLCOM(value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.WriteLine("\nLet's start again!\n\n");
                Thread.Sleep(100);
                Main([]);
            }
        }
    }

}
