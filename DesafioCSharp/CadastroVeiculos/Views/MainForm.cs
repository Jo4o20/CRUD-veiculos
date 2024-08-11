using CadastroVeiculos.Data;
using CadastroVeiculos.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculos.Views
{
    public partial class MainForm : Form
    {

        MySqlConnection Conexao;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Carrega os dados dos veículos no DataGridView ao carregar o formulário
            CarregarVeiculos();
        }

        private void CarregarVeiculos()
        {
            try
            {
                // Usando a classe ConexaoBD para obter a conexão
                MySqlConnection conexao = ConexaoBD.GetConnection();

                if (conexao != null)
                {
                    // Criação do comando SQL para seleção
                    string query = "SELECT * FROM Veiculos";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Preenche o DataTable com os dados
                    da.Fill(dt);

                    // Define o DataSource do DataGridView como o DataTable preenchido
                    dgvVeiculos.DataSource = dt;

                    // Fecha a conexão após o uso
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChassi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoFabricacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorFipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Usando a classe ConexaoBD para obter a conexão
                MySqlConnection conexao = ConexaoBD.GetConnection();

                if (conexao != null)
                {
                    // Criação do comando SQL para inserção
                    string query = "INSERT INTO Veiculos (Placa, Chassi, Marca, Modelo, AnoFabricacao, AnoModelo, ValorFipe, ValorVenda, Observacoes) " +
                                   "VALUES (@Placa, @Chassi, @Marca, @Modelo, @AnoFabricacao, @AnoModelo, @ValorFipe, @ValorVenda, @Observacoes)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    cmd.Parameters.AddWithValue("@Chassi", txtChassi.Text);
                    cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                    cmd.Parameters.AddWithValue("@AnoFabricacao", txtAnoFabricacao.Text);
                    cmd.Parameters.AddWithValue("@AnoModelo", txtAnoModelo.Text);
                    cmd.Parameters.AddWithValue("@ValorFipe", txtValorFipe.Text);
                    cmd.Parameters.AddWithValue("@ValorVenda", txtValorVenda.Text);
                    cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text);

                    // Executa o comando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Veículo adicionado com sucesso!");

                    // Fecha a conexão após o uso
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de texto
            txtObservacoes.Text = string.Empty;
            txtValorVenda.Text = string.Empty;
            txtValorFipe.Text = string.Empty;
            txtAnoModelo.Text = string.Empty;
            txtAnoFabricacao.Text = string.Empty;
            txtChassi.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
