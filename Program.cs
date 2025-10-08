using Spectre.Console;

namespace LCOM.Calc
{
    public class LCOM
    {
        static void Main(string[] args)
        {

            //Greeting message :)
            AnsiConsole.Write(
                new FigletText("LCOM.Calc").LeftJustified().Color(Color.Blue)
            );

            //Option menu for operations
            //1 - Select a directory or file from the system to scan attributes, fields and classes
            //2 - Input amount of attribues and methods manually

            var options = Display.OptionsMenu();

            switch (options)
            {
                case 1:
                    AnsiConsole.Write("File scanning...!");
                    break;
                case 2:
                    AnsiConsole.Write("Input data manually!");
                    break;
            }

            try
            {
                //This is the calculation block
                FileReader.Read();
                var result = Display.InputValues();
                decimal value = Calculator.Calculate(result);
                Display.PrintLCOM(value);
            }

            //Exception handling for multiple purposes
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
