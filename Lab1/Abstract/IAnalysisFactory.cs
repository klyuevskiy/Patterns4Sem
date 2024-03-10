using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание Абстрактная фабрика B(медицина)
 */

namespace Lab1.Abstract
{
    /// <summary>
    /// Абстрактная фабрика для создания инфракструктуры анализов
    /// </summary>
    public interface IAnalysisFactory
    {
        /// <summary>
        /// Создать доктора
        /// </summary>
        /// <returns></returns>
        IDoctor CreateDoctor();

        /// <summary>
        /// Создать материал
        /// </summary>
        /// <returns></returns>
        IAnalysisMaterial CreateMaterial();
    }
}
