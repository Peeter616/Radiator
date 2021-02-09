using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiator
{
    class Tranzystor_MOSFET:Tranzystor
    {

        double rth;//prąd płynący przez tranzystor
        double rthcj;//rezystancja termiczna złącze do obudowy
        double rthcs;//rezystancja termiczna obudowa do radiatora
        double rthja;//rezystancja termiczna złącze do otoczenia
        double tj;//temperatura złącza
        double tc;//temperatura obudowy

        /// <summary>
        /// gettery, settery
        /// </summary>

        public double Rth
        {
            set
            {
                rth = value;
            }
            get
            {
                return rth;
            }
        }
        public double Rthcj
        {
            set
            {
                rthcj = value;
            }
            get
            {
                return rthcj;
            }
        }
        public double Rthcs
        {
            set
            {
                rthcs = value;
            }
            get
            {
                return rthcs;
            }
        }
        public double Rthja
        {
            set
            {
                rthja = value;
            }
            get
            {
                return rthja;
            }
        }
        public double Tj
        {
            set
            {
                tj = value;
            }
            get
            {
                return tj;
            }
        }
        public double Tc
        {
            set
            {
                tc = value;
            }
            get
            {
                return tc;
            }
        }

        /// <summary>
        /// gettery, settery
        /// </summary>

        double Rth_wzor()//funkcja zwracająca sumę rezestancji termicznych
        {
            return Rthcj + Rthja + Rthcs;
        }

        double Tj_wzor(double i, double Ta)//funkcja zwracająca temperaturę złącza
        {
            return Rth * i + Ta;
        }

        double Tc_wzor(double i, double Ta)//funkcja zwracająca temperaturę obudowy
        {
            return (Rthcj + Rthja) * i + Ta;
        }

        public Tranzystor_MOSFET()//konstruktor domyślny
        {
            Rthcj = 0.45;
            Rthja = 0.5;
            Rthcs = 1.4;
            Rth = Rth_wzor();
        }
        public Tranzystor_MOSFET(double u, double r, double rthcj, double rthja, double rthcs) : base(u, r)//konstruktor przeciążony inicjowany w konstruktorze klasy rodzica
        {
            Rthcj = rthcj;
            Rthja = rthja;
            Rthcs = rthcs;
            Rth = Rth_wzor();
        }
        public void RysujWykresTranzystora(System.Windows.Forms.DataVisualization.Charting.Chart wykres, double Ta)
        {
            wykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;//wykres liniowy
            for (double i = 0; i < U + 1; i ++)
                wykres.Series[0].Points.AddXY(i, Tj_wzor(P_wzor(i, I_wzor(i)), Ta));//rysowanie wykresu

            wykres.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (double i = 0; i < U + 1; i ++)
                wykres.Series[1].Points.AddXY(i, Tc_wzor(P_wzor(i, I_wzor(i)), Ta));
        }
        public void CzyśćWykres(System.Windows.Forms.DataVisualization.Charting.Chart wykres)
        {
            wykres.Series.Clear();
            wykres.Series.Add("Temperatura złącza tranzystora");
            wykres.Series.Add("Temperatura obudowy tranzystora");
            wykres.Series[1].Points.Clear();
            wykres.Series[0].Points.Clear();//czyszczenie wykresu
        }
    }
}
