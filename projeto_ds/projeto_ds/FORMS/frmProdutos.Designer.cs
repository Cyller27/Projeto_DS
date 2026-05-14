namespace projeto_ds.FORMS
{
    partial class frmProdutos
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNomeprod = new System.Windows.Forms.Label();
            this.grpCadastrarproduto = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecoprod = new System.Windows.Forms.Label();
            this.txtNomeprod = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCadastrarproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeprod
            // 
            this.lblNomeprod.AutoSize = true;
            this.lblNomeprod.Location = new System.Drawing.Point(6, 16);
            this.lblNomeprod.Name = "lblNomeprod";
            this.lblNomeprod.Size = new System.Drawing.Size(38, 13);
            this.lblNomeprod.TabIndex = 0;
            this.lblNomeprod.Text = "Nome:";
            this.lblNomeprod.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpCadastrarproduto
            // 
            this.grpCadastrarproduto.Controls.Add(this.txtNomeprod);
            this.grpCadastrarproduto.Controls.Add(this.lblPrecoprod);
            this.grpCadastrarproduto.Controls.Add(this.textBox1);
            this.grpCadastrarproduto.Controls.Add(this.lblNomeprod);
            this.grpCadastrarproduto.Location = new System.Drawing.Point(42, 73);
            this.grpCadastrarproduto.Name = "grpCadastrarproduto";
            this.grpCadastrarproduto.Size = new System.Drawing.Size(320, 100);
            this.grpCadastrarproduto.TabIndex = 2;
            this.grpCadastrarproduto.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblPrecoprod
            // 
            this.lblPrecoprod.AutoSize = true;
            this.lblPrecoprod.Location = new System.Drawing.Point(9, 51);
            this.lblPrecoprod.Name = "lblPrecoprod";
            this.lblPrecoprod.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoprod.TabIndex = 3;
            this.lblPrecoprod.Text = "Preço:";
            // 
            // txtNomeprod
            // 
            this.txtNomeprod.Location = new System.Drawing.Point(49, 14);
            this.txtNomeprod.Name = "txtNomeprod";
            this.txtNomeprod.Size = new System.Drawing.Size(191, 20);
            this.txtNomeprod.TabIndex = 4;
            this.txtNomeprod.Text = " ";
            this.txtNomeprod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 23);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "CADASTRAR PRODUTO";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpCadastrarproduto);
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.grpCadastrarproduto.ResumeLayout(false);
            this.grpCadastrarproduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNomeprod;
        private System.Windows.Forms.GroupBox grpCadastrarproduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNomeprod;
        private System.Windows.Forms.Label lblPrecoprod;
        private System.Windows.Forms.Label lblTitulo;
    }
}