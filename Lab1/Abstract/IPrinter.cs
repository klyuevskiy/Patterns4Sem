using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    public interface IPrinter
    {
        /// <summary>
        /// Напечатать сообщение с переносом строки
        /// </summary>
        /// <param name="message">сообщение</param>
        void Print(string message);
    }
}
