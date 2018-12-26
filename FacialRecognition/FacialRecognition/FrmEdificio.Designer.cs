namespace FacialRecognition
{
    partial class FrmEdificio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdificio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdedificio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridEdificio = new System.Windows.Forms.DataGridView();
            this.idedificioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbedificioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprodDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprodDataSet1 = new FacialRecognition.dbprodDataSet1();
            this.dataGridDepartamento = new System.Windows.Forms.DataGridView();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idedificioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdeptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbedificioTableAdapter = new FacialRecognition.dbprodDataSet1TableAdapters.tbedificioTableAdapter();
            this.tbdeptoTableAdapter = new FacialRecognition.dbprodDataSet1TableAdapters.tbdeptoTableAdapter();
            this.cboidedificio = new System.Windows.Forms.ComboBox();
            this.tbedificioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbedificioTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Edificio:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre :";
            // 
            // txtIdedificio
            // 
            this.txtIdedificio.Location = new System.Drawing.Point(147, 61);
            this.txtIdedificio.Location = new System.Drawing.Point(147, 61);
            this.txtIdedificio.Location = new System.Drawing.Point(147, 44);
            this.txtIdedificio.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdedificio.Name = "txtIdedificio";
            this.txtIdedificio.Size = new System.Drawing.Size(56, 22);
            this.txtIdedificio.TabIndex = 3;
            this.txtIdedificio.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(147, 105);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 158);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btningresar.Location = new System.Drawing.Point(13, 216);
            this.btningresar.Location = new System.Drawing.Point(13, 216);
            this.btningresar.Location = new System.Drawing.Point(13, 199);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(120, 43);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Ingresar ";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnmodificar.Location = new System.Drawing.Point(155, 216);
            this.btnmodificar.Location = new System.Drawing.Point(155, 216);
            this.btnmodificar.Location = new System.Drawing.Point(155, 199);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(128, 43);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btneliminar.Location = new System.Drawing.Point(312, 216);
            this.btneliminar.Location = new System.Drawing.Point(312, 216);
            this.btneliminar.Location = new System.Drawing.Point(312, 199);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(121, 43);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.button4.Location = new System.Drawing.Point(818, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(10, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Edificio :  ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.button3.Location = new System.Drawing.Point(312, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 27;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.button2.Location = new System.Drawing.Point(155, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.button1.Location = new System.Drawing.Point(13, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ingresar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpiso
            // 
            this.txtpiso.Location = new System.Drawing.Point(102, 451);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.Size = new System.Drawing.Size(191, 22);
            this.txtpiso.TabIndex = 24;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(102, 410);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(191, 22);
            this.txtnumero.TabIndex = 23;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // txtiddepto
            /*
            this.txtiddepto.Location = new System.Drawing.Point(102, 364);
            this.txtiddepto.Name = "txtiddepto";
            this.txtiddepto.Size = new System.Drawing.Size(72, 22);
            this.txtiddepto.TabIndex = 22;*/
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(10, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Piso  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(10, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 9);
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 9);
            // label7
            // 
            /*
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(10, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id Depto :";*/
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ingreso Edificios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 357);
            this.label9.Location = new System.Drawing.Point(99, 357);

            this.label9.Location = new System.Drawing.Point(12, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ingreso Departamentos :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridEdificio
            // 
            this.dataGridEdificio.AutoGenerateColumns = false;
            this.dataGridEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEdificio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idedificioDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridEdificio.DataSource = this.tbedificioBindingSource;
            this.dataGridEdificio.Location = new System.Drawing.Point(491, 44);
            this.dataGridEdificio.Name = "dataGridEdificio";
            this.dataGridEdificio.Size = new System.Drawing.Size(439, 201);
            this.dataGridEdificio.TabIndex = 31;
            // 
            // idedificioDataGridViewTextBoxColumn
            // 
            this.idedificioDataGridViewTextBoxColumn.DataPropertyName = "id_edificio";
            this.idedificioDataGridViewTextBoxColumn.HeaderText = "id_edificio";
            this.idedificioDataGridViewTextBoxColumn.Name = "idedificioDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // tbedificioBindingSource
            // 
            this.tbedificioBindingSource.DataMember = "tbedificio";
            this.tbedificioBindingSource.DataSource = this.dbprodDataSet1BindingSource;
            // 
            // dbprodDataSet1BindingSource
            // 
            this.dbprodDataSet1BindingSource.DataSource = this.dbprodDataSet1;
            this.dbprodDataSet1BindingSource.Position = 0;
            // 
            // dbprodDataSet1
            // 
            this.dbprodDataSet1.DataSetName = "dbprodDataSet1";
            this.dbprodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridDepartamento
            // 
            this.dataGridDepartamento.AutoGenerateColumns = false;
            this.dataGridDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.idedificioDataGridViewTextBoxColumn1});
            this.dataGridDepartamento.DataSource = this.tbdeptoBindingSource;
            this.dataGridDepartamento.Location = new System.Drawing.Point(491, 290);
            this.dataGridDepartamento.Name = "dataGridDepartamento";
            this.dataGridDepartamento.Size = new System.Drawing.Size(439, 321);
            this.dataGridDepartamento.TabIndex = 32;
            // 
            // deptoDataGridViewTextBoxColumn
            // 
            this.deptoDataGridViewTextBoxColumn.DataPropertyName = "depto";
            this.deptoDataGridViewTextBoxColumn.HeaderText = "depto";
            this.deptoDataGridViewTextBoxColumn.Name = "deptoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            // 
            // idedificioDataGridViewTextBoxColumn1
            // 
            this.idedificioDataGridViewTextBoxColumn1.DataPropertyName = "id_edificio";
            this.idedificioDataGridViewTextBoxColumn1.HeaderText = "id_edificio";
            this.idedificioDataGridViewTextBoxColumn1.Name = "idedificioDataGridViewTextBoxColumn1";
            // 
            // tbdeptoBindingSource
            // 
            this.tbdeptoBindingSource.DataMember = "tbdepto";
            this.tbdeptoBindingSource.DataSource = this.dbprodDataSet1BindingSource;
            // 
            // tbedificioTableAdapter
            // 
            this.tbedificioTableAdapter.ClearBeforeFill = true;
            // 
            // tbdeptoTableAdapter
            // 
            this.tbdeptoTableAdapter.ClearBeforeFill = true;
            // 
            // cboidedificio
            // 
            this.cboidedificio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbedificioBindingSource, "nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboidedificio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbedificioBindingSource, "nombre", true));
            this.cboidedificio.DataSource = this.tbedificioBindingSource;
            this.cboidedificio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbedificioBindingSource, "nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboidedificio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbedificioBindingSource, "nombre", true));
            this.cboidedificio.DataSource = this.tbedificioBindingSource;
            this.cboidedificio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbedificioBindingSource, "id_edificio", true));
            this.cboidedificio.DataSource = this.tbedificioBindingSource1;
            this.cboidedificio.DisplayMember = "nombre";
            this.cboidedificio.FormattingEnabled = true;
            this.cboidedificio.Location = new System.Drawing.Point(102, 492);
            this.cboidedificio.Name = "cboidedificio";
            this.cboidedificio.Size = new System.Drawing.Size(191, 24);
            this.cboidedificio.TabIndex = 33;
            this.cboidedificio.ValueMember = "id_edificio";
            this.cboidedificio.SelectedIndexChanged += new System.EventHandler(this.cboidedificio_SelectedIndexChanged);
            // 
            // tbedificioBindingSource1
            // 
            this.tbedificioBindingSource1.DataMember = "tbedificio";
            this.tbedificioBindingSource1.DataSource = this.dbprodDataSet1BindingSource;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(517, 261);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FacialRecognition.Properties.Resources._040_concept;
            this.pictureBox2.Location = new System.Drawing.Point(382, 438);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tbedificioTableAdapterBindingSource
            // 
            this.tbedificioTableAdapterBindingSource.DataSource = typeof(FacialRecognition.dbprodDataSet1TableAdapters.tbedificioTableAdapter);
            // 
            // FrmEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(947, 627);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cboidedificio);
            this.Controls.Add(this.dataGridDepartamento);
            this.Controls.Add(this.dataGridEdificio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpiso);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIdedificio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEdificio";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.FrmEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbedificioTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdedificio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridEdificio;
        private System.Windows.Forms.BindingSource dbprodDataSet1BindingSource;
        private dbprodDataSet1 dbprodDataSet1;
        private System.Windows.Forms.DataGridView dataGridDepartamento;
        private System.Windows.Forms.BindingSource tbedificioBindingSource;
        private dbprodDataSet1TableAdapters.tbedificioTableAdapter tbedificioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idedificioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbdeptoBindingSource;
        private dbprodDataSet1TableAdapters.tbdeptoTableAdapter tbdeptoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idedificioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cboidedificio;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.BindingSource tbedificioBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource tbedificioTableAdapterBindingSource;
    }
}