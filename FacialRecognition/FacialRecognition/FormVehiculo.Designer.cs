namespace FacialRecognition
{
    partial class FormVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtmarca = new ZBobb.AlphaBlendTextBox();
            this.txtpatente = new ZBobb.AlphaBlendTextBox();
            this.txtcolor = new ZBobb.AlphaBlendTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.combodepto = new System.Windows.Forms.ComboBox();
            this.dbprodDataSet1 = new FacialRecognition.dbprodDataSet1();
            this.tbdeptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbdeptoTableAdapter = new FacialRecognition.dbprodDataSet1TableAdapters.tbdeptoTableAdapter();
            this.timeVisita = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(354, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO VEHICULOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 50);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacialRecognition.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtmarca
            // 
            this.txtmarca.BackAlpha = 10;
            this.txtmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmarca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtmarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.txtmarca.Location = new System.Drawing.Point(395, 254);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(240, 20);
            this.txtmarca.TabIndex = 3;
            this.txtmarca.Text = "MARCA";
            this.txtmarca.Enter += new System.EventHandler(this.txtmarca_Enter);
            this.txtmarca.Leave += new System.EventHandler(this.txtmarca_Leave);
            // 
            // txtpatente
            // 
            this.txtpatente.BackAlpha = 10;
            this.txtpatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtpatente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpatente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtpatente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.txtpatente.Location = new System.Drawing.Point(395, 309);
            this.txtpatente.Name = "txtpatente";
            this.txtpatente.Size = new System.Drawing.Size(240, 20);
            this.txtpatente.TabIndex = 4;
            this.txtpatente.Text = "PATENTE";
            this.txtpatente.Enter += new System.EventHandler(this.txtpatente_Enter);
            this.txtpatente.Leave += new System.EventHandler(this.txtpatente_Leave);
            // 
            // txtcolor
            // 
            this.txtcolor.BackAlpha = 10;
            this.txtcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcolor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.txtcolor.Location = new System.Drawing.Point(395, 207);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(240, 20);
            this.txtcolor.TabIndex = 5;
            this.txtcolor.Text = "COLOR";
            this.txtcolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtcolor_DragEnter);
            this.txtcolor.Leave += new System.EventHandler(this.txtcolor_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnIngresar.Location = new System.Drawing.Point(382, 443);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(253, 29);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // combodepto
            // 
            this.combodepto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbdeptoBindingSource, "numero", true));
            this.combodepto.DataSource = this.tbdeptoBindingSource;
            this.combodepto.DisplayMember = "numero";
            this.combodepto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combodepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.combodepto.FormattingEnabled = true;
            this.combodepto.Location = new System.Drawing.Point(395, 143);
            this.combodepto.Name = "combodepto";
            this.combodepto.Size = new System.Drawing.Size(240, 29);
            this.combodepto.TabIndex = 7;
            this.combodepto.Text = "Departamento";
            this.combodepto.ValueMember = "numero";
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
            // timeVisita
            // 
            this.timeVisita.Interval = 60000;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::FacialRecognition.Properties.Resources.slider_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(999, 685);
            this.Controls.Add(this.combodepto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtpatente);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVehiculo";
            this.Opacity = 0.8D;
            this.Text = "FormVehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox txtmarca;
        private ZBobb.AlphaBlendTextBox txtpatente;
        private ZBobb.AlphaBlendTextBox txtcolor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox combodepto;
        private dbprodDataSet1 dbprodDataSet1;
        private System.Windows.Forms.BindingSource tbdeptoBindingSource;
        private dbprodDataSet1TableAdapters.tbdeptoTableAdapter tbdeptoTableAdapter;
        private System.Windows.Forms.Timer timeVisita;
    }
}