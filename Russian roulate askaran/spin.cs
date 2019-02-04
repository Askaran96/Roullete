using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_roulate_askaran
{
    class spin
    {
        public int load, shoot =0;
        public int Spin;
        public int reset = 2;
        public int spined(int spine)
        {
            if (spine == 6)// this code checks if spin is equal to 6
            {
                spine = 1;//this code sets the value of spin to 1

            }
            else
            {
                spine++;//this code increase the value of spin by 1
            }

            return spine;
        }
    }
}
