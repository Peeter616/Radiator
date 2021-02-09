using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiator
{
    class Otoczenie
    {
        double ta;//temperatura otoczenia
        public double Ta
        {
            set
            {
                ta = value;
            }
            get
            {
                return ta;
            }
        }
        public Otoczenie(double ta = 25)//konstruktor z domyślną wartością parametru
        {
            this.ta = ta;
        }
    }
}
