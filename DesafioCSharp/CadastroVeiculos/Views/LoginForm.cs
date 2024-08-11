using CadastroVeiculos.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;


namespace CadastroVeiculos.Views
{
    public partial class LoginForm : Form
    {

        MySqlConnection Conexao;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //primeiro testei com um banco de dados local para teste
            try
            {
                // Usando a classe ConexaoBD para obter a conexão
                MySqlConnection Conexao = ConexaoBD.GetConnection();

                if (Conexao != null)
                {
                    string query = "SELECT * FROM Usuarios WHERE NomeUsuario = @nomeUsuario AND Senha = @senha";
                    MySqlCommand cmd = new MySqlCommand(query, Conexao);
                    cmd.Parameters.AddWithValue("@nomeUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    DbDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        // Usuário encontrado, redirecionar para o MainForm
                        this.Hide();  // Esconde o LoginForm
                        MainForm mainForm = new MainForm();
                        mainForm.Show();  // Mostra o MainForm
                    }
                    else
                    {
                        // Usuário ou senha incorretos
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }

                    // Fecha a conexão após o uso
                    Conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo dos campos de usuário e senha
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
