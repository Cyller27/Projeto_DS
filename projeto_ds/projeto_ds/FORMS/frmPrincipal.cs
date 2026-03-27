using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_ds.FORMS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblTexto.Text = "Bem-vindo ao sistema de gerenciamento de clientes e produtos!\n" + "Trabalho com seriedade e responsabilidade.";
            string nome = "";

            var strConexao = "server=localhost;uid=root;password=root;database=cleanall";

            try
            {
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    using (var comando = new MySqlCommand(
                        "SELECT nome FROM usuario WHERE id_usuario = " + Sessao.UsuarioId, conexao))
                    {
                        nome = Convert.ToString(comando.ExecuteScalar());
                        lblTitulo.Text = "Bem-vindo, " + nome + "!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nome de usúario não encontrado" + ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formClientes = new frmClientes();
            formClientes.Show();
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProdutos = new frmProdutos();
            formProdutos.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPedidos = new frmPedidos();
            formPedidos.Show();
            this.Close();
    }
    }
}
