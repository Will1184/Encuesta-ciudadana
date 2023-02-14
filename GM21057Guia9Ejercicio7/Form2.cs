using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM21057Guia9Ejercicio7
{
    public partial class Form2 : Form
    {
        public Form2(double promAltura,double promEdad,string nombreMasComun)
        {

            InitializeComponent();
            //SALIDA DE DATOS
            dataGridPromedios.Rows[0].Cells[0].Value = promEdad;
            dataGridPromedios.Rows[0].Cells[1].Value = promAltura;
            dataGridPromedios.Rows[0].Cells[2].Value = nombreMasComun.ToUpper();

        }

        //SALIR DEL PROGRAMA
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
