using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3___29
{
    class Iznimka : ApplicationException
    {
        public string Poruka;

        public Iznimka (string poruka)
        {
            Poruka = poruka;
        }
        //aaaa test
        //aaa test 2
    }
}
