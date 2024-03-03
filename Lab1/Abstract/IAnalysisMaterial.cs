using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    /// <summary>
    /// Материал для анализов
    /// </summary>
    public interface IAnalysisMaterial
    {
        /// <summary>
        /// Сообщить информацию о материале
        /// </summary>
        /// <param name="printer">куда сообщать</param>
        void Print(IPrinter printer);
    }
}
