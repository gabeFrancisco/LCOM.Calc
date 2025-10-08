using Spectre.Console;

namespace LCOM.Calc
{
    public class FileReader
    {
        private static string _path = "ClassProps.cs";

        public static void Read()
        {
            using var reader = new StreamReader(_path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine()!;
                AnsiConsole.WriteLine(line);
            }
        }
    }
}