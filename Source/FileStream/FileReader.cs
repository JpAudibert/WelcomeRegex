using System.IO;

namespace Source.FileStream
{
    class FileReader
    {
        public static string[] readFile(string file)
        {
            string[] numberValues = { };

            if (File.Exists(file))
            {
                numberValues = File.ReadAllLines(file);
            }

            return numberValues;
        }

        public static string readLine(string file)
        {
            string line = "";

            if (File.Exists(file))
            {
                line = File.ReadLines(file).ToString();
            }

            return line;

        }

    }
}