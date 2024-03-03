using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Blood
{
    internal class BloodAnalysis : Analysis
    {
        // гепатит C
        private readonly bool haveHCV;

        public BloodAnalysis(IAnalysisMaterial material, bool haveHCV) : base(material)
        {
            this.haveHCV = haveHCV;
        }

        public override void Print(IPrinter printer)
        {
            material.Print(printer);
            printer.Print(GetHCVMessage());
        }

        private string GetHCVMessage()
        {
            if (haveHCV)
                return "Поздравляем, у вас гепатит C!";
            return "Не расстраивайтесь, но у вас нет гепатита C.";
        }
    }
}
