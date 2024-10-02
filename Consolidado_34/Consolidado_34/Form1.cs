using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consolidado_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplicacion1_Click(object sender, EventArgs e)
        {
            DanielVinascoIsaza_Fase2.Form1 frmAplicacion1 = new DanielVinascoIsaza_Fase2.Form1();
            frmAplicacion1.Show();


        }

        private void btnAplicacion2_Click(object sender, EventArgs e)
        {
            Melodias_Perfectas.Form1 frmAplicacion2 = new Melodias_Perfectas.Form1();
            frmAplicacion2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAplicacion3_Click(object sender, EventArgs e)
        {
            Fase2JessicaCatherineLozano.Form1 frmAplicacion3 = new Fase2JessicaCatherineLozano.Form1();
            frmAplicacion3.Show();

        }
    }
}
