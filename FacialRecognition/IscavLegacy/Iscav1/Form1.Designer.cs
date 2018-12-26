namespace FacialRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartCamara = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnCapturaCara = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresaCara = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCamara
            // 
            this.btnStartCamara.Location = new System.Drawing.Point(18, 195);
            this.btnStartCamara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartCamara.Name = "btnStartCamara";
            this.btnStartCamara.Size = new System.Drawing.Size(112, 35);
            this.btnStartCamara.TabIndex = 0;
            this.btnStartCamara.Text = "1.Start";
            this.btnStartCamara.UseVisualStyleBackColor = true;
            this.btnStartCamara.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(153, 60);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(424, 360);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnCapturaCara
            // 
            this.btnCapturaCara.Location = new System.Drawing.Point(638, 229);
            this.btnCapturaCara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapturaCara.Name = "btnCapturaCara";
            this.btnCapturaCara.Size = new System.Drawing.Size(112, 83);
            this.btnCapturaCara.TabIndex = 3;
            this.btnCapturaCara.Text = "2.Detect face";
            this.btnCapturaCara.UseVisualStyleBackColor = true;
            this.btnCapturaCara.Visible = false;
            this.btnCapturaCara.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(783, 132);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(321, 248);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(783, 425);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter name";
            this.label1.Visible = false;
            // 
            // btnIngresaCara
            // 
            this.btnIngresaCara.Location = new System.Drawing.Point(1005, 465);
            this.btnIngresaCara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresaCara.Name = "btnIngresaCara";
            this.btnIngresaCara.Size = new System.Drawing.Size(112, 83);
            this.btnIngresaCara.TabIndex = 7;
            this.btnIngresaCara.Text = "3.Train face";
            this.btnIngresaCara.UseVisualStyleBackColor = true;
            this.btnIngresaCara.Visible = false;
            this.btnIngresaCara.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1004, 60);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to start";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 555);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIngresaCara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnCapturaCara);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnStartCamara);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCamara;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnCapturaCara;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresaCara;
        private System.Windows.Forms.Button btnBack;



    }
}

