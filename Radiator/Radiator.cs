using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiator
{
    class Radiator
    {
        double Ts_wzor(double Rthja, double U, double R, double Ta)//funkcja wyliczająca temperaturę obudowy radiatora
        {
            return Rthja * U * U / R + Ta;
        }
        public Radiator()
        {

        }
        public void RysujWykresRadiatora(System.Windows.Forms.DataVisualization.Charting.Chart wykres, double Rthja, double U, double R, double Ta)
        {
            wykres.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;//wykres liniowy
            for (double i = 0; i < U + 1; i++)
            {
                wykres.Series[2].Points.AddXY(i, Ts_wzor(Rthja, i, R, Ta));//rysowanie wykresu}
            }
        }
        public void CzyśćWykres(System.Windows.Forms.DataVisualization.Charting.Chart wykres)
        {
            wykres.Series.Add("Temperatura radiatora");
            wykres.Series[2].Points.Clear();//czyszczenie wykresu
        }
    }
}
