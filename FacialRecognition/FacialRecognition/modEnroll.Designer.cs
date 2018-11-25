namespace FacialRecognition
{
    partial class modEnroll
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
            this.btnStartCam = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnDetectCam = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblFaceID = new System.Windows.Forms.Label();
            this.cbTipoPerson = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.boxDepto = new System.Windows.Forms.ComboBox();
            this.dbprodDataSet1 = new FacialRecognition.dbprodDataSet1();
            this.tbdeptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbdeptoTableAdapter = new FacialRecognition.dbprodDataSet1TableAdapters.tbdeptoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnStartCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnStartCam.Location = new System.Drawing.Point(93, 305);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(106, 34);
            this.btnStartCam.TabIndex = 0;
            this.btnStartCam.Text = "1.Inicia Camara";
            this.btnStartCam.UseVisualStyleBackColor = false;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(21, 39);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(283, 234);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnDetectCam
            // 
            this.btnDetectCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnDetectCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDetectCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnDetectCam.Location = new System.Drawing.Point(327, 70);
            this.btnDetectCam.Name = "btnDetectCam";
            this.btnDetectCam.Size = new System.Drawing.Size(96, 54);
            this.btnDetectCam.TabIndex = 3;
            this.btnDetectCam.Text = "2.Detecta Cara";
            this.btnDetectCam.UseVisualStyleBackColor = false;
            this.btnDetectCam.Visible = false;
            this.btnDetectCam.Click += new System.EventHandler(this.btnDetectCam_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(429, 39);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(214, 161);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(429, 236);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(202, 20);
            this.boxNombre.TabIndex = 5;
            this.boxNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(426, 220);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Ingresa tu nombre :";
            this.lblNombre.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnIngresar.Location = new System.Drawing.Point(442, 367);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(144, 54);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "3.Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnBack.Location = new System.Drawing.Point(685, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 34);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Volver al menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(426, 270);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(80, 13);
            this.lblDepto.TabIndex = 9;
            this.lblDepto.Text = "Departamento :";
            this.lblDepto.Visible = false;
            // 
            // lblFaceID
            // 
            this.lblFaceID.AutoSize = true;
            this.lblFaceID.Location = new System.Drawing.Point(650, 220);
            this.lblFaceID.Name = "lblFaceID";
            this.lblFaceID.Size = new System.Drawing.Size(42, 13);
            this.lblFaceID.TabIndex = 11;
            this.lblFaceID.Text = "FaceID";
            this.lblFaceID.Visible = false;
            this.lblFaceID.Click += new System.EventHandler(this.lblFaceID_Click);
            // 
            // cbTipoPerson
            // 
            this.cbTipoPerson.FormattingEnabled = true;
            this.cbTipoPerson.Items.AddRange(new object[] {
            "Visita",
            "Residente"});
            this.cbTipoPerson.Location = new System.Drawing.Point(429, 332);
            this.cbTipoPerson.Name = "cbTipoPerson";
            this.cbTipoPerson.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPerson.TabIndex = 7;
            this.cbTipoPerson.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMensaje.Location = new System.Drawing.Point(64, 377);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 13;
            // 
            // boxDepto
            // 
            this.boxDepto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbdeptoBindingSource, "numero", true));
            this.boxDepto.DataSource = this.tbdeptoBindingSource;
            this.boxDepto.DisplayMember = "numero";
            this.boxDepto.FormattingEnabled = true;
            this.boxDepto.Location = new System.Drawing.Point(429, 286);
            this.boxDepto.Name = "boxDepto";
            this.boxDepto.Size = new System.Drawing.Size(202, 21);
            this.boxDepto.TabIndex = 14;
            this.boxDepto.ValueMember = "numero";
            // 
            // dbprodDataSet1
            // 
            this.dbprodDataSet1.DataSetName = "dbprodDataSet1";
            this.dbprodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbdeptoBindingSource
            // 
            this.tbdeptoBindingSource.DataMember = "tbdepto";
            this.tbdeptoBindingSource.DataSource = this.dbprodDataSet1;
            // 
            // tbdeptoTableAdapter
            // 
            this.tbdeptoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo :";
            this.label1.Visible = false;
            // 
            // modEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(838, 424);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDepto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDepto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cbTipoPerson);
            this.Controls.Add(this.lblFaceID);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnDetectCam);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnStartCam);
            this.Name = "modEnroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolamiento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCam;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnDetectCam;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblFaceID;
        private System.Windows.Forms.ComboBox cbTipoPerson;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ComboBox boxDepto;
        private dbprodDataSet1 dbprodDataSet1;
        private System.Windows.Forms.BindingSource tbdeptoBindingSource;
        private dbprodDataSet1TableAdapters.tbdeptoTableAdapter tbdeptoTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

