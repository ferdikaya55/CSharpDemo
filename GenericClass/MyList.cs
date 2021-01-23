using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
   public class MyList<Tplaka,Tiller>
    {
        Tplaka[] tPlaka;
        Tiller[] tIller;
        public MyList()
        {
            tPlaka = new Tplaka[0];
            tIller = new Tiller[0];
        }
        public void Add(Tplaka plaka, Tiller il)
        {
            Tplaka[] tempPlaka = tPlaka;
            tPlaka = new Tplaka[tPlaka.Length + 1];
            Tiller[] tempIller = tIller;
            tIller = new Tiller[tIller.Length + 1];

            for (int i = 0; i < tempPlaka.Length; i++)
            {
                tPlaka[i] = tempPlaka[i];
                tIller[i] = tempIller[i];
            }
            tPlaka[tPlaka.Length - 1] = plaka;
            tIller[tIller.Length - 1] = il;

        }
        public int Count
        {
            get { return tPlaka.Length; }
        }
      
    }
}
