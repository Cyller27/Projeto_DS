namespace projeto_ds.FORMS
{
    partial class frmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEscondersenha = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(18, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "";
            this.txtUsername.Text = "Nome de usuário";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Location = new System.Drawing.Point(18, 58);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(187, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnEscondersenha);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtSenha);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Location = new System.Drawing.Point(306, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(268, 163);
            this.grpLogin.TabIndex = 3;
            this.grpLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(18, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(232, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto_ds.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEscondersenha
            // 
            this.btnEscondersenha.Image = global::projeto_ds.Properties.Resources.icons8_visível_24;
            this.btnEscondersenha.Location = new System.Drawing.Point(211, 56);
            this.btnEscondersenha.Name = "btnEscondersenha";
            this.btnEscondersenha.Size = new System.Drawing.Size(39, 28);
            this.btnEscondersenha.TabIndex = 3;
            this.btnEscondersenha.UseVisualStyleBackColor = true;
            this.btnEscondersenha.Click += new System.EventHandler(this.btnEscondersenha_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(586, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEscondersenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}