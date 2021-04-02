using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_4_Problema_1
{
    public struct Seguros
    {
        public int año;
        public string marca;
        public int vigencia;
        public string placas;
        public string color;
        public string modelo;

        public Seguros(int iAño, string sMarca, int iVigencia, string sPlacas, string sColor, string sModelo)
        {
            año = iAño;
            marca = sMarca;
            vigencia = iVigencia;
            placas = sPlacas;
            color = sColor;
            modelo = sModelo;
        }
    }
    public partial class Form1 : Form
    {
        int contador = 0;
        Seguros[] seguros = new Seguros[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            seguros[contador] = new Seguros();
            seguros[contador].año = Convert.ToInt32(txtAño.Text);
            seguros[contador].vigencia = Convert.ToInt32(txtVigencia.Text);
            seguros[contador].marca = txtMarca.Text;
            seguros[contador].placas = txtPlacas.Text;
            seguros[contador].color = txtColor.Text;
            seguros[contador].modelo = txtModelo.Text;

            dgvAutos.Rows.Add(1);
            dgvAutos.Rows[contador].Cells["Año"].Value = txtAño.Text;
            dgvAutos.Rows[contador].Cells["Vigencia"].Value = txtVigencia.Text;
            dgvAutos.Rows[contador].Cells["Marca"].Value = txtMarca.Text;
            dgvAutos.Rows[contador].Cells["Placas"].Value = txtPlacas.Text;
            dgvAutos.Rows[contador].Cells["Color"].Value = txtColor.Text;
            dgvAutos.Rows[contador].Cells["Modelo"].Value = txtModelo.Text;
            dgvAutos.Refresh();
            Limpiar();
            contador++;
        }
        private void Limpiar()
        {
            txtAño.Text = string.Empty;
            txtVigencia.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPlacas.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtAño.Focus();
        }

        private void btnVencidos_Click(object sender, EventArgs e)
        {
            dgvAutos.Rows.Clear();
            int g = 0;
            for (int i = 0; i < contador; i++)
            {
                if (seguros[i].vigencia < 2021)
                {
                    dgvAutos.Rows.Add(1);
                    dgvAutos.Rows[g].Cells["Año"].Value = seguros[i].año.ToString();
                    dgvAutos.Rows[g].Cells["Vigencia"].Value = seguros[i].vigencia.ToString();
                    dgvAutos.Rows[g].Cells["Marca"].Value = seguros[i].marca;
                    dgvAutos.Rows[g].Cells["Placas"].Value = seguros[i].placas;
                    dgvAutos.Rows[g].Cells["Color"].Value = seguros[i].color;
                    dgvAutos.Rows[g].Cells["Modelo"].Value = seguros[i].modelo;
                    dgvAutos.Refresh();
                    g++;
                }
            }
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            dgvAutos.Rows.Clear();
            int g = 0;
            for (int i = 0; i < contador; i++)
            {
                if (seguros[i].año < 2011)
                {
                    dgvAutos.Rows.Add(1);
                    dgvAutos.Rows[g].Cells["Año"].Value = seguros[i].año.ToString();
                    dgvAutos.Rows[g].Cells["Vigencia"].Value = seguros[i].vigencia.ToString();
                    dgvAutos.Rows[g].Cells["Marca"].Value = seguros[i].marca;
                    dgvAutos.Rows[g].Cells["Placas"].Value = seguros[i].placas;
                    dgvAutos.Rows[g].Cells["Color"].Value = seguros[i].color;
                    dgvAutos.Rows[g].Cells["Modelo"].Value = seguros[i].modelo;
                    dgvAutos.Refresh();
                    g++;
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvAutos.Rows.Clear();
            for (int i = 0; i < contador; i++)
            {
                dgvAutos.Rows.Add(1);
                dgvAutos.Rows[i].Cells["Año"].Value = seguros[i].año.ToString();
                dgvAutos.Rows[i].Cells["Vigencia"].Value = seguros[i].vigencia.ToString();
                dgvAutos.Rows[i].Cells["Marca"].Value = seguros[i].marca;
                dgvAutos.Rows[i].Cells["Placas"].Value = seguros[i].placas;
                dgvAutos.Rows[i].Cells["Color"].Value = seguros[i].color;
                dgvAutos.Rows[i].Cells["Modelo"].Value = seguros[i].modelo;
                dgvAutos.Refresh();
            }
        }
    }
}
