using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewMembersSalesManager : BaseSalesManager
    {
        public override void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine("Yeni üyelere özel olan satış fiyatından satıldı.");
        }
    }
}
