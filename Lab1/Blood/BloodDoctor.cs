using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Blood
{
    internal class BloodDoctor : IDoctor
    {
        // рандомайзер для крови
        Random random = new();

        public Analysis CreateAnalysis(IAnalysisMaterial material)
        {
            bool haveHCV = IsHaveHCV();
            return new BloodAnalysis(material, haveHCV);
        }

        private bool IsHaveHCV()
        {
            return random.Next(0, 2) == 0;
        }
    }
}
