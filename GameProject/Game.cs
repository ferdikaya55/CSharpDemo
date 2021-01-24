using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Game
    {
        public string Name { get; set; }
        public int SalePrice { get; set; }
    }

    public class DiscountGame : Game
    {
        public int DiscountPrice { get; set; }
    }
}
