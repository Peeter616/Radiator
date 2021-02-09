using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiator
{
    class Tranzystor
    {
        protected double i;//prąd płynący przez tranzystor
        protected double u;//napięcie na tranzystorze
        protected double r;//rezystancja tranzystora
        protected double p;//moc tranzystora

        /// <summary>
        /// gettery, settery
        /// </summary>

        public double U
        {
            set
            { 
                u = value;
            }
            get
            {
                return u;
            }
        }
        public double I
        {
            set
            {
                i = value;
            }
            get
            {
                return i;
            }
        }
        public double R
        {
            set
            {
                r = value;
            }
            get
            {
                return r;
            }
        }
        public double P
        {
            set
            {
                p = value;
            }
            get
            {
                return p;
            }
        }

        /// <summary>
        /// gettery, settery
        /// </summary>

        protected double I_wzor(double j)//funkcja licząca wartość prądu
        {
            return j / R;
        }

        protected double P_wzor(double j, double l)//funkcja licząca wartość mocy
        {
            return j * l;
        }

        protected void PoliczP()//Obliczanie prądu i mocy
        {
            P = P_wzor(U, I = I_wzor(U));
        }

        public Tranzystor()//konstruktor domyślny
        {
            U = 10;
            R = 4;
            PoliczP();
        }

        public Tranzystor(double u, double r)//konstruktor przeciążony
        {
            U = u;
            R = r;
            PoliczP();
        }
    }
}
