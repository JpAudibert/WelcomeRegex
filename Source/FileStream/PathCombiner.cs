using System;
using System.Collections.Generic;
using System.IO;

namespace Source.FileStream
{
    public class PathCombiner
    {
        public static string combineInputPaths(List<string> fileToCombine)
        {
            string currentDir = Environment.CurrentDirectory;
            fileToCombine.Insert(0, currentDir);
            string fileCombined = Path.GetFullPath(Path.Combine(fileToCombine.ToArray()));
            return fileCombined;
        }
    }
}