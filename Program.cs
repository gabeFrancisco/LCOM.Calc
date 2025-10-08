using Spectre.Console;

namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {
            AnsiConsole.Write(
                new FigletText("LCOM.Calc").LeftJustified().Color(Color.Blue)
            );

            AnsiConsole.WriteLine(Display.OptionsMenu());

            try
            {
                var result = Display.InputValues();
                decimal value = Calculator.Calculate(result);
                Display.PrintLCOM(value);
            }
            catch (IndexOutOfRangeException ex)
            {
                AnsiConsole.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.WriteLine("\nLet's start again!\n\n");
                Thread.Sleep(100);
                Main([]);
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex);
            }
        }
    }

}
