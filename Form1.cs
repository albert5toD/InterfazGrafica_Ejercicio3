using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtH_T.Clear();
            txtP_H.Clear();
            txtAFP.Clear();
            txtSFS.Clear();
            txtSueldoNeto.Clear();
            txtSueldoBruto.Clear();
            txtTotalDescuentos.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double afp, sfs, p_h, total_descuento, sueldo_neto, sueldo_bruto;

            int h_t;

            p_h = double.Parse(txtP_H.Text);
            h_t = int.Parse(txtH_T.Text);

            sueldo_bruto = p_h * h_t;

            afp = (sueldo_bruto * 2.87) / 100;
            sfs = (sueldo_bruto * 3.04) / 100;

            total_descuento = afp + sfs;
            sueldo_neto = sueldo_bruto - total_descuento;

            txtAFP.Text = afp.ToString();
            txtSFS.Text = sfs.ToString();
            txtSueldoBruto.Text = sueldo_bruto.ToString();
            txtTotalDescuentos.Text = total_descuento.ToString();
            txtSueldoNeto.Text = sueldo_neto.ToString();

        }
    }
}
