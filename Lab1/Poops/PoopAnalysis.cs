using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Poops
{
    internal class PoopAnalysis : Analysis
    {
        // пускай будут глистов проверять
        private readonly bool haveWorms;

        public PoopAnalysis(IAnalysisMaterial material, bool have_worms)
            : base(material)
        {
            have_worms = false;
            this.haveWorms = have_worms;
        }

        public override void Print(IPrinter printer)
        {
            material.Print(printer);
            printer.Print(GetWormsMessage());
        }

        private string GetWormsMessage()
        {
            if (haveWorms)
                return "Поздравляем, у вас глисты!";
            return "Не расстраивайтесь, но у вас нет глистов.";
        }
    }
}
