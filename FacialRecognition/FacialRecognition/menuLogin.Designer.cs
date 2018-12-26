namespace FacialRecognition
{
    
    partial class menuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuLogin));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btningresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtuser = new ZBobb.AlphaBlendTextBox();
            this.txtpass = new ZBobb.AlphaBlendTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btningresar.Location = new System.Drawing.Point(185, 222);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(194, 35);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(560, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(583, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacialRecognition.Properties.Resources.Logo_ISCAV;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtuser
            // 
            this.txtuser.BackAlpha = 10;
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.txtuser.Location = new System.Drawing.Point(195, 126);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(174, 19);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackAlpha = 10;
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.txtpass.Location = new System.Drawing.Point(195, 171);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(248, 19);
            this.txtpass.TabIndex = 2;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.linkLabel1.Location = new System.Drawing.Point(201, 274);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿ Ha Olvidado Su Contraseña ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.lblPass.Location = new System.Drawing.Point(191, 170);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(119, 20);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "CONTRASEÑA";
            this.lblPass.MouseEnter += new System.EventHandler(this.lblPass_MouseEnter);
            this.lblPass.MouseLeave += new System.EventHandler(this.lblPass_MouseLeave);
            // 
            // menuLogin
            // 
            this.AcceptButton = this.btningresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FacialRecognition.Properties.Resources.slider_11;
            this.ClientSize = new System.Drawing.Size(605, 402);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 402);
            this.MinimumSize = new System.Drawing.Size(605, 402);
            this.Name = "menuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos";
            this.Load += new System.EventHandler(this.menuLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox txtpass;
        private ZBobb.AlphaBlendTextBox txtuser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPass;
    }
}