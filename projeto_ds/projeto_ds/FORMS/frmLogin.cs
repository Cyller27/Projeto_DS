using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_ds.FORMS
{

    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {

            InitializeComponent();
           
        }

        private bool mostrarSenha = false;
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.TextChanged -= txtSenha_TextChanged; // Desvincula o evento para evitar loop infinito
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        { 
            txtUsername.Text = "";
            txtUsername.TextChanged -= txtUsername_TextChanged; // Desvincula o evento para evitar loop infinito
        }

  



        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = Convert.ToString(txtUsername.Text);
            string senha = Convert.ToString(txtSenha.Text);

            if(username == "admin" && senha == "admin")
            {
                MessageBox.Show("Login bem-sucedido!");
                // Aqui você pode abrir o formulário principal do sistema
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.Show();
                this.Hide(); // Esconde o formulário de login
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
                txtSenha.Text = ""; // Limpa o campo de senha
                txtSenha.Focus(); // Foca o campo de senha para facilitar a nova tentativa
            }
        }

        private void btnEscondersenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
            if (txtSenha.UseSystemPasswordChar)
            {
                btnEscondersenha.Image = Properties.Resources.icons8_olho_fechado_24; // Substitua pelo caminho da sua imagem de olho fechado
            }
            else
            {
                btnEscondersenha.Image = Properties.Resources.icons8_visível_24; // Substitua pelo caminho da sua imagem de olho aberto
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
