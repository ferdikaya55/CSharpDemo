using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameSalesManager :BaseSalesManager
    {
        public override void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncuya " + game.Name + " oyunu " + game.SalePrice + " TL fiyatından satıldı.");
        }
    }
}
