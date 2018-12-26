using Iscav1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacialRecognition
{
    public partial class modDepto101 : Form
    {
        public modDepto101()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
           // modDepto sm = new modDepto();
           // sm.Show();
            this.Hide();
        }

        private void modDetalleDepto_Load(object sender, EventArgs e)
        {
            string ndepto = FacialRecognition.numDepto.nDepto;
            lblDepto.Text = ndepto;
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet3.tbpersona' Puede moverla o quitarla según sea necesario.
            // this.tbpersonaTableAdapter.Fill(this.dbprodDataSet3.tbpersona);

            var select = "SELECT * FROM tbpersona where tipopersona='Residente' and depto ='"+ndepto+"'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];

            var select2 = "SELECT * FROM tbpersona where tipopersona='Visita' and depto ='" + ndepto + "'";
            var c2 = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter2 = new System.Data.SqlClient.SqlDataAdapter(select2, c2);

            var commandBuilder2 = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter2);
            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds2.Tables[0];





        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbpersonaTableAdapter.FillBy(this.dbprodDataSet3.tbpersona);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
