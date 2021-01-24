using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class DiscountGameManager : BaseSalesManager
    {
        public void AddDiscountGame()
        {
            Console.WriteLine("İndirimli ürün eklendi.");
        }
        public void UpdateDiscountGame()
        {
            Console.WriteLine("İndirimli ürün güncellendi.");
        }
        public void DeleteDiscountGame()
        {
            Console.WriteLine("İndirimli ürün silindi.");
        }
        public override void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncuya " + game.Name + " oyunu " + game.SalePrice + " TL ile indirimli fiyatından satıldı.");

        }
    }
}
