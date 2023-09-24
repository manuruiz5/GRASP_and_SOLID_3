using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter:IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}