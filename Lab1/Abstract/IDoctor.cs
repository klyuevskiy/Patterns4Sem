using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    /// <summary>
    /// Доктор, который делает анализы для пациентов
    /// </summary>
    public interface IDoctor
    {
        /// <summary>
        /// Сделать анализ по материалу
        /// </summary>
        /// <param name="analysis">результат анализа</param>
        /// <returns>Результат анализа</returns>
        Analysis CreateAnalysis(IAnalysisMaterial material);
    }
}
