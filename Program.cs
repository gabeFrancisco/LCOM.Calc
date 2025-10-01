namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            var props = new ClassProps(4, 5, [1,3,2,5]);

            decimal value = Calculator.Calculate(props);

            Display.PrintLCOM(value);
        }
    }

}
