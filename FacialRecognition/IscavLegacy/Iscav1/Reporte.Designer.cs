namespace Iscav1
{
    partial class Reporte
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.iscavDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iscavDBDataSet = new Iscav1.iscavDBDataSet();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.AllowUserToOrderColumns = true;
            this.dataGridReporte.AutoGenerateColumns = false;
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.DataSource = this.iscavDBDataSetBindingSource;
            this.dataGridReporte.Location = new System.Drawing.Point(452, 73);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.RowTemplate.Height = 28;
            this.dataGridReporte.Size = new System.Drawing.Size(240, 150);
            this.dataGridReporte.TabIndex = 1;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Muestra Enrolados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Iscav1.Properties.Resources.login_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridReporte);
            this.Controls.Add(this.button1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscavDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.BindingSource iscavDBDataSetBindingSource;
        private iscavDBDataSet iscavDBDataSet;
        private System.Windows.Forms.Button button2;
    }
}