using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Poops
{
    internal class PoopAnalysisFactory : IAnalysisFactory
    {
        private PoopDoctor? doctor = null;

        public IDoctor CreateDoctor()
        {
            // синглтон для врачей, нам же не нужно бесконечно врачей, денег их зарплаты не хватит
            if (doctor == null)
                doctor = new PoopDoctor();
            return doctor;
        }

        public IAnalysisMaterial CreateMaterial()
        {
            return new Poops();
        }
    }
}
