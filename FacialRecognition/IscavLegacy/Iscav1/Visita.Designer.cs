namespace Iscav1
{
    partial class Visita
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechasalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaingreso = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtIdvisita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVisita = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBuscarIDC = new System.Windows.Forms.Button();
            this.btnModReserva = new System.Windows.Forms.Button();
            this.btnMostrarReser = new System.Windows.Forms.Button();
            this.iscavDBDataSet = new Iscav1.iscavDBDataSet();
            this.iscavDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idvisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(318, 331);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(318, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(318, 284);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(175, 284);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(18, 284);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar Visita";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechasalida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtFechaingreso);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtApeMaterno);
            this.groupBox1.Controls.Add(this.txtIdvisita);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 240);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitas";
            // 
            // txtFechasalida
            // 
            this.txtFechasalida.Location = new System.Drawing.Point(140, 203);
            this.txtFechasalida.Name = "txtFechasalida";
            this.txtFechasalida.Size = new System.Drawing.Size(156, 20);
            this.txtFechasalida.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha Salida :";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(140, 88);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(156, 20);
            this.txtApePaterno.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // txtFechaingreso
            // 
            this.txtFechaingreso.Location = new System.Drawing.Point(140, 174);
            this.txtFechaingreso.Name = "txtFechaingreso";
            this.txtFechaingreso.Size = new System.Drawing.Size(156, 20);
            this.txtFechaingreso.TabIndex = 32;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(140, 146);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(156, 20);
            this.txtRut.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Rut :";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(140, 116);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(156, 20);
            this.txtApeMaterno.TabIndex = 30;
            // 
            // txtIdvisita
            // 
            this.txtIdvisita.Location = new System.Drawing.Point(140, 26);
            this.txtIdvisita.Name = "txtIdvisita";
            this.txtIdvisita.Size = new System.Drawing.Size(100, 20);
            this.txtIdvisita.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Visita :";
            // 
            // dataGridVisita
            // 
            this.dataGridVisita.AutoGenerateColumns = false;
            this.dataGridVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvisitaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPDataGridViewTextBoxColumn,
            this.apellidoMDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.fechainDataGridViewTextBoxColumn,
            this.fechasalDataGridViewTextBoxColumn});
            this.dataGridVisita.DataMember = "tbvisita";
            this.dataGridVisita.DataSource = this.iscavDBDataSetBindingSource;
            this.dataGridVisita.Location = new System.Drawing.Point(434, 58);
            this.dataGridVisita.Name = "dataGridVisita";
            this.dataGridVisita.Size = new System.Drawing.Size(693, 385);
            this.dataGridVisita.TabIndex = 22;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(542, 19);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 23;
            // 
            // btnBuscarIDC
            // 
            this.btnBuscarIDC.Location = new System.Drawing.Point(18, 331);
            this.btnBuscarIDC.Name = "btnBuscarIDC";
            this.btnBuscarIDC.Size = new System.Drawing.Size(125, 23);
            this.btnBuscarIDC.TabIndex = 24;
            this.btnBuscarIDC.Text = "Buscar ID Visita";
            this.btnBuscarIDC.UseVisualStyleBackColor = true;
            this.btnBuscarIDC.Click += new System.EventHandler(this.btnBuscarIDC_Click);
            // 
            // btnModReserva
            // 
            this.btnModReserva.Location = new System.Drawing.Point(175, 331);
            this.btnModReserva.Name = "btnModReserva";
            this.btnModReserva.Size = new System.Drawing.Size(75, 23);
            this.btnModReserva.TabIndex = 25;
            this.btnModReserva.Text = "Modificar";
            this.btnModReserva.UseVisualStyleBackColor = true;
            this.btnModReserva.Click += new System.EventHandler(this.btnModReserva_Click);
            // 
            // btnMostrarReser
            // 
            this.btnMostrarReser.Location = new System.Drawing.Point(18, 373);
            this.btnMostrarReser.Name = "btnMostrarReser";
            this.btnMostrarReser.Size = new System.Drawing.Size(125, 23);
            this.btnMostrarReser.TabIndex = 26;
            this.btnMostrarReser.Text = "Mostrar Visitas";
            this.btnMostrarReser.UseVisualStyleBackColor = true;
            this.btnMostrarReser.Click += new System.EventHandler(this.btnMostrarReser_Click);
            // 
            // iscavDBDataSet
            // 
            this.iscavDBDataSet.DataSetName = "iscavDBDataSet";
            this.iscavDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iscavDBDataSetBindingSource
            // 
            this.iscavDBDataSetBindingSource.DataSource = this.iscavDBDataSet;
            this.iscavDBDataSetBindingSource.Position = 0;
            // 
            // idvisitaDataGridViewTextBoxColumn
            // 
            this.idvisitaDataGridViewTextBoxColumn.DataPropertyName = "id_visita";
            this.idvisitaDataGridViewTextBoxColumn.HeaderText = "id_visita";
            this.idvisitaDataGridViewTextBoxColumn.Name = "idvisitaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoPDataGridViewTextBoxColumn
            // 
            this.apellidoPDataGridViewTextBoxColumn.DataPropertyName = "apellidoP";
            this.apellidoPDataGridViewTextBoxColumn.HeaderText = "apellidoP";
            this.apellidoPDataGridViewTextBoxColumn.Name = "apellidoPDataGridViewTextBoxColumn";
            // 
            // apellidoMDataGridViewTextBoxColumn
            // 
            this.apellidoMDataGridViewTextBoxColumn.DataPropertyName = "apellidoM";
            this.apellidoMDataGridViewTextBoxColumn.HeaderText = "apellidoM";
            this.apellidoMDataGridViewTextBoxColumn.Name = "apellidoMDataGridViewTextBoxColumn";
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // fechainDataGridViewTextBoxColumn
            // 
            this.fechainDataGridViewTextBoxColumn.DataPropertyName = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.HeaderText = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.Name = "fechainDataGridViewTextBoxColumn";
            // 
            // fechasalDataGridViewTextBoxColumn
            // 
            this.fechasalDataGridViewTextBoxColumn.DataPropertyName = "fecha_sal";
            this.fechasalDataGridViewTextBoxColumn.HeaderText = "fecha_sal";
            this.fechasalDataGridViewTextBoxColumn.Name = "fechasalDataGridViewTextBoxColumn";
            // 
            // Visita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 498);
            this.Controls.Add(this.btnMostrarReser);
            this.Controls.Add(this.btnModReserva);
            this.Controls.Add(this.btnBuscarIDC);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dataGridVisita);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Visita";
            this.Text = "Visita";
            this.Load += new System.EventHandler(this.Visita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaingreso;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtIdvisita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVisita;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnBuscarIDC;
        private System.Windows.Forms.Button btnModReserva;
        private System.Windows.Forms.Button btnMostrarReser;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechasalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource iscavDBDataSetBindingSource;
        private iscavDBDataSet iscavDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalDataGridViewTextBoxColumn;
    }
}