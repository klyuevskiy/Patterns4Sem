using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /* Адаптер американца к русскому.
     * Может быть полезно для туриста, который хочет учиться русским матам */
    internal class AmericanToRussianAdapter : IRussian
    {
        private readonly American american;

        public AmericanToRussianAdapter(American american)
        {
            this.american = american;
        }

        public void Swear()
        {
            american.SwearRussian();
        }
    }
}
