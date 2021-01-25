using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public abstract class BaseSalesManager : IGameSales
    {
        public abstract void Sale(Game game, Gamer gamer);
    }
}
