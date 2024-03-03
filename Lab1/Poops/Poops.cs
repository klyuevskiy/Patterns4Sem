using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Poops
{
    /// <summary>
    /// твой код
    /// </summary>
    internal class Poops : IAnalysisMaterial
    {
        public void Print(IPrinter printer)
        {
            printer.Print("Какашки");
        }
    }
}
