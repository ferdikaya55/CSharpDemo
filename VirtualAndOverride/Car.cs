using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndOverride
{
    public class Car
    {
        public int price = 500;

        // virtual : Bir sınıfın miras alınan sınıflardaki metodunun ezilebilmesini,değişebilmesini sağlar.        
        public virtual int  Price()
        {
            return price + 100;
        }
    }
    public class OldCar:Car
    {
        // override : Miras alınan metodun ezilmesi işlemini sağlar, yani metodun içini değiştirmektir.
        public override int Price()
        {
            return price - 100;
        }
    }
}
