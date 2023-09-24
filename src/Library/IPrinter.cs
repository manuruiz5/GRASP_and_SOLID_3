using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter //aplico lsp para crear la interfaz y luego crear clases que esten dentro de ella
    {
        void Print(string text);
    }
}