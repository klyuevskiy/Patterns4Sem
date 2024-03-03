using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    /// <summary>
    /// Результат анализа
    /// </summary>
    public abstract class Analysis
    {
        protected readonly IAnalysisMaterial material;

        /// <summary>
        /// Создание анализа
        /// </summary>
        /// <param name="material">информация о материале</param>
        public Analysis(IAnalysisMaterial material)
        {
            this.material = material;
        }

        /// <summary>
        /// Печать результата анализа
        /// </summary>
        /// <param name="printer">куда печатать</param>
        abstract public void Print(IPrinter printer);
    }
}
