// Plano (pseudocódigo detalhado):
// 1. Criar uma variável global acessível de qualquer lugar da aplicação.
//    - Implementar uma classe estática `Sessao` com propriedade pública `UsuarioId` (int) e opcional `Nome` (string).
// 2. No processo de login (btnLogin_Click):
//    - Ler `nome` e `senha` dos campos do formulário.
//    - Executar uma consulta que retorna o `id_usuario` correspondente ao par (nome, senha).
//    - Se retornar um id válido:
//        - Atribuir `Sessao.UsuarioId = id_usuario` e `Sessao.Nome = nome`.
//        - Abrir o formulário principal e ocultar o formulário de login.
//    - Se não retornar resultado:
//        - Mostrar mensagem de erro, limpar e focar o campo de senha.
//    - Tratar exceções de conexão/consulta e exibir mensagens apropriadas.
// 3. Mantém-se simples e segura a consulta (parâmetros para evitar SQL Injection).
// 4. A classe `Sessao` é estática e pode ser usada em qualquer outro formulário:
//      int id = Sessao.UsuarioId;

// Nota: Este arquivo inclui a definição da classe de sessão (pode ser extraída para um arquivo próprio `Sessao.cs`).

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
    // Classe estática para armazenar dados de sessão globalmente
    public static class Sessao
    {
        // ID do usuário logado; 0 significa nenhum usuário autenticado
        public static int UsuarioId { get; set; } = 0;

        // Opcional: armazenar nome ou outros dados úteis
        public static string Nome { get; set; } = string.Empty;
    }

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

            // Verifica as credenciais no banco de dados e obtém o id do usuário
            try
            {
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    using (var comando = new MySqlCommand(
                        "SELECT id_usuario FROM usuario WHERE nome = @nome AND senha = @senha LIMIT 1", conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@senha", senha);

                        var result = comando.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int id_usuario = Convert.ToInt32(result);

                            // Armazena o id em variável global (Sessao)
                            Sessao.UsuarioId = id_usuario;
                            Sessao.Nome = nome;

                            // Credenciais válidas, abre o formulário principal
                            //MessageBox.Show("Login bem-sucedido! ID: " + id_usuario);
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