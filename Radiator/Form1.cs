using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tranzystor_MOSFET t1 = new Tranzystor_MOSFET(Convert.ToDouble(numU.Value), Convert.ToDouble(numR.Value), Convert.ToDouble(numRthcj.Value), Convert.ToDouble(numRthja.Value), Convert.ToDouble(numRthcs.Value));
            Otoczenie o1 = new Otoczenie(Convert.ToDouble(numTa.Value));
            Radiator r1 = new Radiator();
            t1.CzyśćWykres(chart1);
            r1.CzyśćWykres(chart1);
            t1.RysujWykresTranzystora(chart1, o1.Ta);
            r1.RysujWykresRadiatora(chart1, t1.Rthja, t1.U, t1.R, o1.Ta);
        }
    }
}
