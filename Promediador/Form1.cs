﻿using System;
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
                // Limpiar Grid
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                // Obtener la cantidad de alumnos
                int cantAl = int.Parse(txtCantAl.Text);

                // Obtener el número de calificaciones
                int canCal = int.Parse(txtCalPorAl.Text);

                // Obtener el promedio aprobatorio
                double prom = double.Parse(txtProm.Text);

                // Indicar número de columnas en el GRID, NO LISTA, CALIFICACIONES, PROMEDIO Y ESTADO
                dataGridView1.ColumnCount = 1 + canCal + 2;

                // Agregar nombre a la primer columna
                dataGridView1.Columns[0].Name = "No. Lista";


                // Ciclo FOR para agregar las columnas necesarias de la cantidad de calificaciones
                // Ya se agreago una columna en la posición 0 : No.Lista

                // Se debe iniciar el ciclo a partir de la posición 1: para ahí comenzar a poner las
                // columas de las calificaciones, son obtenidas de la cantidad de calificaciones.
                for (int col = 1; col <= canCal; col++)
                {
                    // Agregar el nombre de cada columna de calificaciones, 1,2,3...
                    dataGridView1.Columns[col].Name = "Calificación " + col;

                    // Verificar cuando se terminen de agregar las columnas de calificaciones
                    // Para poder agregar las columnas de PROMEDIO y ESTADO
                    // Cuando estos valores sean iguales, las calificaciones ya se agregaron.
                    if (col == canCal)
                    {
                        dataGridView1.Columns[col + 1].Name = "Promedio";
                        dataGridView1.Columns[col + 2].Name = "Estado";
                    }
                }
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
