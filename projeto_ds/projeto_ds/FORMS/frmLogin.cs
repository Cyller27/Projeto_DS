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
using MySql.Data.MySqlClient;

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
            // Obtém o nome de usuário e senha do formulário
            string nome = txtUsername.Text.Trim();
            string senha = txtSenha.Text;
            // Conexão com o banco de dados
            var strConexao = "server=localhost;uid=root;password=root;database=cleanall";
            // Verifica as credenciais no banco de dados
            try
            {
                using (var conexao = new MySqlConnection(strConexao))
                {
                    // Abre a conexão
                    conexao.Open();
                    // Prepara o comando SQL para verificar as credenciais
                    using (var comando = new MySqlCommand(
                        // A consulta SQL conta quantos registros correspondem ao nome e senha fornecidos
                        "SELECT COUNT(1) FROM usuario WHERE nome = @nome AND senha = @senha", conexao))
                    {
                        // Adiciona os parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@senha", senha);
                        // Executa o comando e obtém o número de correspondências
                        int matches = Convert.ToInt32(comando.ExecuteScalar());
                        // Verifica se houve correspondência
                        if (matches > 0)
                        {
                            // Credenciais válidas, abre o formulário principal
                            MessageBox.Show("Login bem-sucedido!");
                            var formPrincipal = new frmPrincipal();
                            formPrincipal.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Credenciais inválidas, exibe uma mensagem de erro
                            MessageBox.Show("Credenciais inválidas. Tente novamente.");
                            txtSenha.Clear();
                            txtSenha.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso haja um problema ao verificar as credenciais
                MessageBox.Show("Erro ao verificar credenciais: " + ex.Message);
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
            /*
            try
            {
                var strConexao = "server=localhost;uid=root;password=root;database=cleanall";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();

                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");

                var comando = new MySqlCommand("SELECT * FROM usuario", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show($"{reader["id_usuario"]} => {reader["nome"]} => {reader["senha"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            */

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
