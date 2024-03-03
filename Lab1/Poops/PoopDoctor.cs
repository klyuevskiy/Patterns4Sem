using Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Poops
{
    internal class PoopDoctor : IDoctor
    {
        // рандомайзер для глистов
        Random random = new();

        public Analysis CreateAnalysis(IAnalysisMaterial material)
        {
            bool haveWorms = IsHaveWorms();
            return new PoopAnalysis(material, haveWorms);
        }

        private bool IsHaveWorms()
        {
            return random.Next(0, 2) == 0;
        }
    }
}
