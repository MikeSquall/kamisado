using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Plateau
    {
        private Case[] board;
        private Pion[] tours;

        public Plateau(Case[] b, Pion[] t)
        {
            this.board = b;
            this.tours = t;
        }
    }
}
