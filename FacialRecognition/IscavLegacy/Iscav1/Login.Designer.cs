namespace Iscav1
{
    partial class Login
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
            this.btningresar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btningresar.Image = global::Iscav1.Properties.Resources.login_background;
            this.btningresar.Location = new System.Drawing.Point(479, 352);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(331, 71);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);

            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(539, 159);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(271, 26);
            this.txtid.TabIndex = 0;


            
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(539, 252);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(278, 26);
            this.txtpass.TabIndex = 1;


            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::Iscav1.Properties.Resources.login_background;
            this.label1.Location = new System.Drawing.Point(214, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "User :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Image = global::Iscav1.Properties.Resources.login_background;
            this.label2.Location = new System.Drawing.Point(164, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label3.Image = global::Iscav1.Properties.Resources.login_background;
            this.label3.Location = new System.Drawing.Point(454, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 155);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login Iscav";


            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Iscav1.Properties.Resources.login_background;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btningresar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

            //  
            //        // 
            //        // Login
            //        // 
            //        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //       
            //        this.ClientSize = new System.Drawing.Size(1363, 479);
            //        this.Controls.Add(this.label3);
            //        this.Controls.Add(this.btn_login);
            //        this.Controls.Add(this.txt_password);
            //        this.Controls.Add(this.label2);
            //        this.Controls.Add(this.label1);
            //        this.Controls.Add(this.txt_user);
            //        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //        
            //        this.Name = "Login";
            //        
            //        this.Text = "Login";
            //        this.ResumeLayout(false);
            //        this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


//////namespace Iscav1
//{
//    partial class Login
//{
//    /// <summary>
//    /// Required designer variable.
//    /// </summary>
//    private System.ComponentModel.IContainer components = null;

//    /// <summary>
//    /// Clean up any resources being used.
//    /// </summary>
//    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//    protected override void Dispose(bool disposing)
//    {
//        if (disposing && (components != null))
//        {
//            components.Dispose();
//        }
//        base.Dispose(disposing);
//    }

//    #region Windows Form Designer generated code

//    /// <summary>
//    /// Required method for Designer support - do not modify
//    /// the contents of this method with the code editor.
//    /// </summary>
//    private void InitializeComponent()
//    {
//        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
//        this.txt_user = new System.Windows.Forms.TextBox();
//        this.label1 = new System.Windows.Forms.Label();
//        this.label2 = new System.Windows.Forms.Label();
//        this.txt_password = new System.Windows.Forms.TextBox();
//        this.btn_login = new System.Windows.Forms.Button();
//        this.label3 = new System.Windows.Forms.Label();
//        this.SuspendLayout();
//        // 
//        // txt_user
//        // 
//        this.txt_user.Location = new System.Drawing.Point(539, 159);
//        this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//        this.txt_user.Name = "txt_user";
//        this.txt_user.Size = new System.Drawing.Size(271, 26);
//        this.txt_user.TabIndex = 0;
//        // 
//        // label1
//        // 
//        this.label1.AutoSize = true;
//        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
//        this.label1.Location = new System.Drawing.Point(284, 159);
//        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//        this.label1.Name = "label1";
//        this.label1.Size = new System.Drawing.Size(137, 32);
//        this.label1.TabIndex = 1;
//        this.label1.Text = "Usuario :";
//        // 
//        // label2
//        // 
//        this.label2.AutoSize = true;
//        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
//        this.label2.Location = new System.Drawing.Point(284, 245);
//        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//        this.label2.Name = "label2";
//        this.label2.Size = new System.Drawing.Size(189, 32);
//        this.label2.TabIndex = 2;
//        this.label2.Text = "Contraseña :";
//        // 

//    }

//    #endregion

//    private System.Windows.Forms.TextBox txt_user;
//    private System.Windows.Forms.Label label1;
//    private System.Windows.Forms.Label label2;
//    private System.Windows.Forms.TextBox txt_password;
//    private System.Windows.Forms.Button btn_login;
//    private System.Windows.Forms.Label label3;
//}
//}