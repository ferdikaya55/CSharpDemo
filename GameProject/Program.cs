using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // InitGamer();
            //SalesGame();
            Game game1 = new Game();
            game1.Name = "Araba Yarışı";
            game1.SalePrice = 250;
            Gamer gamer = new Gamer();
            gamer.FirstName = "Engin";
       
            BaseSalesManager gameSales = new GameSalesManager();
            BaseSalesManager discountSales = new DiscountGameManager();
            BaseSalesManager newMemberSales = new NewMembersSalesManager();
            gameSales.Sale(game1,gamer);
            discountSales.Sale(game1,gamer);
            newMemberSales.Sale(game1,gamer);

            DiscountGameManager discountGameManager = new DiscountGameManager();
            discountGameManager.AddDiscountGame();
            discountGameManager.UpdateDiscountGame();
            discountGameManager.DeleteDiscountGame();
        }
        static void SalesGame()
        {
            Game game1 = new Game();
            game1.Name = "Futbol";
            game1.SalePrice = 100;
            Gamer gamer = new Gamer();
            gamer.FirstName = "Ferdi";
            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sale(game1, gamer);

        }
        static void InitGamer()
        {
            Gamer gamer1 = new Gamer();
            gamer1.IdentiyNumber = 11111111111;
            gamer1.FirstName = "Ferdi";
            gamer1.LastName = "Kaya";
            gamer1.BirthYear = 1996;
            Gamer gamer2 = new Gamer();
            gamer2.IdentiyNumber = 222222222222;
            gamer2.FirstName = "Engin";
            gamer2.LastName = "Demiroğ";
            gamer2.BirthYear = 1985;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.SaveGamer(new Gamer
            {
                IdentiyNumber = 123445,
                BirthYear = 1999,
                FirstName = "Ali"
            });
            
            
            gamerManager.SaveGamer(gamer1);
            gamerManager.SaveGamer(gamer2);

            List<Gamer> listGamers = new List<Gamer>();
            listGamers.Add(gamer1);
            listGamers.Add(gamer2);

            gamerManager.ListGamer(listGamers);

            gamerManager.UpdateGamer(gamer1);

            gamerManager.DeleteGamer(gamer2);

            gamerManager.RemoveListGamer(listGamers);

        }
    }
}
