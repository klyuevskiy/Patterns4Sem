using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /* Отель для русских */
    internal class RussianHotel
    {
        /* сами русские */
        private readonly List<IRussian> russians = new();

        /*
         *  ругистрация русского.
         *  Возвращать указатель на себя, чтобы делать цепочку
         */
        public RussianHotel CheckIn(IRussian russian)
        {
            russians.Add(russian);
            return this;
        }

        /* Каждый русский должен хотя бы раз в день хорошо выругаться, персонал отеля за этим следит */
        public void SwearAll()
        {
            russians.ForEach(russian => russian.Swear());
        }
    }
}
