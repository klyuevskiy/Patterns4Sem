using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Abstract;

namespace Lab1.Blood
{
    public class BloodAnalysisFactory : IAnalysisFactory
    {
        private BloodDoctor? doctor = null;

        public IDoctor CreateDoctor()
        {
            if (doctor == null)
                doctor = new BloodDoctor();
            return doctor;
        }

        public IAnalysisMaterial CreateMaterial()
        {
            return new Blood();
        }
    }
}
