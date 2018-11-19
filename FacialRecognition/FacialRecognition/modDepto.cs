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
    public partial class modDepto : Form
    {
        public modDepto()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpDeptos.Visible = true;
            btnDetpo1.Text = "101";
            btnDetpo2.Text = "102";
            btnDetpo3.Text = "103";
            btnDetpo4.Text = "104";
            btnDetpo5.Text = "105";
            btnDetpo6.Text = "106";
            btnDetpo7.Text = "107";
            btnDetpo8.Text = "108";

        }

        private void btnPiso2_Click(object sender, EventArgs e)
        {
            grpDeptos.Visible = true;
            btnDetpo1.Text = "201";
            btnDetpo2.Text = "202";
            btnDetpo3.Text = "203";
            btnDetpo4.Text = "204";
            btnDetpo5.Text = "205";
            btnDetpo6.Text = "206";
            btnDetpo7.Text = "207";
            btnDetpo8.Text = "208";
        }

        private void btnPiso3_Click(object sender, EventArgs e)
        {
            grpDeptos.Visible = true;
            btnDetpo1.Text = "301";
            btnDetpo2.Text = "302";
            btnDetpo3.Text = "303";
            btnDetpo4.Text = "304";
            btnDetpo5.Text = "305";
            btnDetpo6.Text = "306";
            btnDetpo7.Text = "307";
            btnDetpo8.Text = "308";
        }

        private void btnPiso4_Click(object sender, EventArgs e)
        {
            grpDeptos.Visible = true;
            btnDetpo1.Text = "401";
            btnDetpo2.Text = "402";
            btnDetpo3.Text = "403";
            btnDetpo4.Text = "404";
            btnDetpo5.Text = "405";
            btnDetpo6.Text = "406";
            btnDetpo7.Text = "407";
            btnDetpo8.Text = "408";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SelectMenu sm = new SelectMenu();
            sm.Show();
            this.Hide();
            
        }

        private void btnDetpo1_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo1.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();


        }

        private void btnDetpo2_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo2.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo3_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo3.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo4_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo4.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo5_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo5.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo6_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo6.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo7_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo7.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void btnDetpo8_Click(object sender, EventArgs e)
        {
            FacialRecognition.numDepto.nDepto = btnDetpo8.Text;
            modDepto101 depto = new modDepto101();
            depto.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
