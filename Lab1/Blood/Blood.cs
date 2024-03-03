using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Blood
{
    internal class Blood : IAnalysisMaterial
    {
        public void Print(IPrinter printer)
        {
            printer.Print("Кровь");
        }
    }
}
