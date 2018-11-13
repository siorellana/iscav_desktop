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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modEnroll));
            this.btnStartCam = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnDetectCam = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblFaceID = new System.Windows.Forms.Label();
            this.cbTipoPerson = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.boxDepto = new System.Windows.Forms.ComboBox();
            this.tbdeptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprodDataSet1 = new FacialRecognition.dbprodDataSet1();
            this.tbdeptoTableAdapter = new FacialRecognition.dbprodDataSet1TableAdapters.tbdeptoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnStartCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnStartCam.Location = new System.Drawing.Point(111, 338);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(111, 52);
            this.btnStartCam.TabIndex = 0;
            this.btnStartCam.Text = "1.Iniciar Camara";
            this.btnStartCam.UseVisualStyleBackColor = false;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(11, 64);
            this.imageBox1.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageBox1.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(320, 240);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnDetectCam
            // 
            this.btnDetectCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnDetectCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDetectCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnDetectCam.Location = new System.Drawing.Point(333, 171);
            this.btnDetectCam.Name = "btnDetectCam";
            this.btnDetectCam.Size = new System.Drawing.Size(116, 54);
            this.btnDetectCam.TabIndex = 3;
            this.btnDetectCam.Text = "2.Detectar Rostro";
            this.btnDetectCam.UseVisualStyleBackColor = false;
            this.btnDetectCam.Visible = false;
            this.btnDetectCam.Click += new System.EventHandler(this.btnDetectCam_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(622, 86);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(100, 100);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(493, 261);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(202, 20);
            this.boxNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(490, 245);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Ingresa tu nombre :";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnIngresar.Location = new System.Drawing.Point(653, 366);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 40);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "3.Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(490, 295);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(80, 13);
            this.lblDepto.TabIndex = 9;
            this.lblDepto.Text = "Departamento :";
            // 
            // lblFaceID
            // 
            this.lblFaceID.AutoSize = true;
            this.lblFaceID.Location = new System.Drawing.Point(747, 147);
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
            this.cbTipoPerson.Location = new System.Drawing.Point(493, 366);
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
            this.boxDepto.FormattingEnabled = true;
            this.boxDepto.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408"});
            this.boxDepto.Location = new System.Drawing.Point(493, 311);
            this.boxDepto.Name = "boxDepto";
            this.boxDepto.Size = new System.Drawing.Size(202, 21);
            this.boxDepto.TabIndex = 14;
            // 
            // tbdeptoBindingSource
            // 
            this.tbdeptoBindingSource.DataMember = "tbdepto";
            this.tbdeptoBindingSource.DataSource = this.dbprodDataSet1;
            // 
            // dbprodDataSet1
            // 
            this.dbprodDataSet1.DataSetName = "dbprodDataSet1";
            this.dbprodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbdeptoTableAdapter
            // 
            this.tbdeptoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo :";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnAtras);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 58);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(795, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnAtras.Location = new System.Drawing.Point(653, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(136, 32);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Volver a Menu";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(818, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FacialRecognition.Properties.Resources.Logo_ISCAV;
            this.pictureBox3.Location = new System.Drawing.Point(6, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // modEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.BackgroundImage = global::FacialRecognition.Properties.Resources.fondo_840_500;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDepto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cbTipoPerson);
            this.Controls.Add(this.lblFaceID);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnDetectCam);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnStartCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(840, 500);
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "modEnroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolamiento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

