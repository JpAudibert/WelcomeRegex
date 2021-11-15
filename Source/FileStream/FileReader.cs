using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Source.FileStream
{
    class FileReader
    {
        public static List<string> ReadFile(string file)
        {
            string[] lines = { };

            if (File.Exists(file))
            {
                lines = File.ReadAllLines(file);
            }

            List<string> linesList = lines.ToList();

            return linesList;
        }
    }
}