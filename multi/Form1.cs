﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Doblemente_Enlazada_Circular_N_1
{
    public partial class Form1 : Form
    {

        ListaAsig Lista1;
        public Form1()
        {
            InitializeComponent();
            Lista1 = new ListaAsig();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox2.Text);
            string x = textBox1.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Escriba los datos");
                return;
            }
            else
            {
                Lista1.CrearLista(textBox1.Text, int.Parse(textBox2.Text));
                textBox1.Text = "Escriba aqui";
                textBox2.Text = "";
                textBox1.Focus();
                textBox1.Text = null;
                textBox2.Text = null;
                listBox1.Items.Add(x);
                listBox2.Items.Add(p);

            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //TNodo elim;
            if (Lista1.BuscarAsignado(textBox1.Text))
            {
                //elim = (TNodo)Lista1.Eliminar();
                Lista1.EliminarLista(textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
             MessageBox.Show("Lista Vacia");
            }                
        }

        private void Primero_Click(object sender, EventArgs e)
        {
            TNodo nodoPrimero;
            nodoPrimero = (TNodo)Lista1.GetPrimero();
            if(nodoPrimero == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                textBox1.Text = nodoPrimero.DameNombre();
                textBox2.Text = nodoPrimero.DameNumero().ToString();
            }
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            if (Lista1.BuscarAsignado(textBox1.Text) == true)
            {
                TNodo nodoAnterior = (TNodo)Lista1.GetAnteriorCursor();
                textBox1.Text = nodoAnterior.DameNombre();
                textBox2.Text = (nodoAnterior.DameNumero()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene sucesor");
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            TNodo nodoSiguiente;
            if (Lista1.BuscarAsignado(textBox1.Text) == true)
            {
                nodoSiguiente = (TNodo)Lista1.GetProxCursor();
                textBox1.Text = nodoSiguiente.DameNombre();
                textBox2.Text = (nodoSiguiente.DameNumero()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene nodo siguiente");
            }
        }

        private void Ultimo_Click(object sender, EventArgs e)
        {
            TNodo nodoUltimo;
            nodoUltimo = (TNodo)Lista1.GetUltimo();
            if (nodoUltimo == null)
            {
                MessageBox.Show("Lista Vacia");
                return;
            }
            else
            {
                textBox1.Text = nodoUltimo.DameNombre();
                textBox2.Text = nodoUltimo.DameNumero().ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        // funcion que limpia el data 
        public void limpiardata()
        {
            for(int i=0;i< this.dataGridView1.RowCount;i++)
            for(int j=0;j<= this.dataGridView1.ColumnCount-i;j++)
                {
                this.dataGridView1.Rows[i].Cells[j].Value = "";
            }
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
