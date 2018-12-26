//using Negocio;
using FacialRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iscav1
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenuAdmin sele = new SelectMenuAdmin();

            sele.WindowState = FormWindowState.Maximized;
            sele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridReporte.DataSource = AccesoLogica.ObtenerAdmin();
        }
    }
}
