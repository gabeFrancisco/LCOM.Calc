namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            var props = new ClassProps(4, 5, [1,3,2,5]);

            Calculator.Calculate(props);


            // var display = new Display();

            // display.Hello();
        }
    }

}
