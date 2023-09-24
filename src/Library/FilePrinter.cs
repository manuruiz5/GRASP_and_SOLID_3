using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter:IPrinter
    {
        private readonly string filePath;
        public FilePrinter(string filePath)
        {
            this.filePath=filePath;
        }
        public void Print(string text)
        {
            File.WriteAllText(filePath, text);
        }
    }
}