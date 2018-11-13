namespace Iscav1
{
    partial class Propiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propiedad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridPropiedad = new System.Windows.Forms.DataGridView();
            this.idpropiedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscavDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iscavDBDataSet = new Iscav1.iscavDBDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdpropiedad = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrarpropiedad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::Iscav1.Properties.Resources.login_background;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicacion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(30, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Propietario :";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(137, 86);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(137, 116);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(137, 146);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(100, 20);
            this.txtPropietario.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(18, 277);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(109, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(724, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridPropiedad
            // 
            this.dataGridPropiedad.AutoGenerateColumns = false;
            this.dataGridPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPropiedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpropiedadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idpropietarioDataGridViewTextBoxColumn});
            this.dataGridPropiedad.DataMember = "tbpropiedad";
            this.dataGridPropiedad.DataSource = this.iscavDBDataSetBindingSource;
            this.dataGridPropiedad.Location = new System.Drawing.Point(328, 19);
            this.dataGridPropiedad.Name = "dataGridPropiedad";
            this.dataGridPropiedad.Size = new System.Drawing.Size(471, 281);
            this.dataGridPropiedad.TabIndex = 15;
            // 
            // idpropiedadDataGridViewTextBoxColumn
            // 
            this.idpropiedadDataGridViewTextBoxColumn.DataPropertyName = "id_propiedad";
            this.idpropiedadDataGridViewTextBoxColumn.HeaderText = "id_propiedad";
            this.idpropiedadDataGridViewTextBoxColumn.Name = "idpropiedadDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // idpropietarioDataGridViewTextBoxColumn
            // 
            this.idpropietarioDataGridViewTextBoxColumn.DataPropertyName = "id_propietario";
            this.idpropietarioDataGridViewTextBoxColumn.HeaderText = "id_propietario";
            this.idpropietarioDataGridViewTextBoxColumn.Name = "idpropietarioDataGridViewTextBoxColumn";
            // 
            // iscavDBDataSetBindingSource
            // 
            this.iscavDBDataSetBindingSource.DataSource = this.iscavDBDataSet;
            this.iscavDBDataSetBindingSource.Position = 0;
            // 
            // iscavDBDataSet
            // 
            this.iscavDBDataSet.DataSetName = "iscavDBDataSet";
            this.iscavDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = global::Iscav1.Properties.Resources.login_background;
            this.label6.Location = new System.Drawing.Point(33, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id Propiedad :";
            // 
            // txtIdpropiedad
            // 
            this.txtIdpropiedad.Location = new System.Drawing.Point(137, 25);
            this.txtIdpropiedad.Name = "txtIdpropiedad";
            this.txtIdpropiedad.Size = new System.Drawing.Size(100, 20);
            this.txtIdpropiedad.TabIndex = 17;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(390, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Image = global::Iscav1.Properties.Resources.login_background;
            this.label7.Location = new System.Drawing.Point(33, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Direccion :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 53);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // btnMostrarpropiedad
            // 
            this.btnMostrarpropiedad.Location = new System.Drawing.Point(109, 320);
            this.btnMostrarpropiedad.Name = "btnMostrarpropiedad";
            this.btnMostrarpropiedad.Size = new System.Drawing.Size(151, 23);
            this.btnMostrarpropiedad.TabIndex = 23;
            this.btnMostrarpropiedad.Text = "Mostrar Propiedad";
            this.btnMostrarpropiedad.UseVisualStyleBackColor = true;
            this.btnMostrarpropiedad.Click += new System.EventHandler(this.btnMostrarpropiedad_Click);
            // 
            // Propiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 426);
            this.Controls.Add(this.btnMostrarpropiedad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtIdpropiedad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridPropiedad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Propiedad";
            this.Text = "Propiedad";
            this.Load += new System.EventHandler(this.Propiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridPropiedad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdpropiedad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnMostrarpropiedad;
        private System.Windows.Forms.BindingSource iscavDBDataSetBindingSource;
        private iscavDBDataSet iscavDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpropiedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpropietarioDataGridViewTextBoxColumn;
    }
}