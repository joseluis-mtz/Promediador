using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promediador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCantAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
        }

        private void txtCalPorAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
        }

        private void txtProm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
        }

        private void btnProm_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Verifica la información que ingresaste.");
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }
    }
}
