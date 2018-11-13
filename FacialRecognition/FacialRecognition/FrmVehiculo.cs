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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void btninvehiculo_Click(object sender, EventArgs e)
        {
            FormVehiculo fvehiculo = new FormVehiculo();

            fvehiculo.Show();


            this.Hide();
        }
    }
}
