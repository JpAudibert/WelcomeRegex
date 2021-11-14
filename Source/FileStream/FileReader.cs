using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Source.FileStream
{
    class FileReader
    {
        public static List<string> readFile(string file)
        {
            string[] numberValues = { };

            if (File.Exists(file))
            {
                numberValues = File.ReadAllLines(file);
            }

            List<string> numberValuesList = numberValues.ToList();

            return numberValuesList;
        }
    }
}