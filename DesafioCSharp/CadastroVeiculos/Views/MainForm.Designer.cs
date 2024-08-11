namespace CadastroVeiculos.Views
{
    partial class MainForm
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
            btnAdicionar = new Button();
            btnLimpar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPlaca = new TextBox();
            txtChassi = new TextBox();
            txtAnoFabricacao = new TextBox();
            txtAnoModelo = new TextBox();
            txtValorVenda = new TextBox();
            txtValorFipe = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtObservacoes = new TextBox();
            dgvVeiculos = new DataGridView();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 415);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(93, 415);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(174, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(255, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Chassi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 96);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Modelo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 125);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 8;
            label5.Text = "Ano de Fabricação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 154);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 9;
            label6.Text = "Ano do Modelo";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(123, 6);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 23);
            txtPlaca.TabIndex = 10;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(123, 35);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(121, 23);
            txtChassi.TabIndex = 11;
            txtChassi.TextChanged += txtChassi_TextChanged;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Location = new Point(123, 122);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(121, 23);
            txtAnoFabricacao.TabIndex = 13;
            txtAnoFabricacao.TextChanged += txtAnoFabricacao_TextChanged;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Location = new Point(125, 151);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(119, 23);
            txtAnoModelo.TabIndex = 14;
            txtAnoModelo.TextChanged += txtAnoModelo_TextChanged;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(125, 209);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(119, 23);
            txtValorVenda.TabIndex = 15;
            txtValorVenda.TextChanged += txtValorVenda_TextChanged;
            // 
            // txtValorFipe
            // 
            txtValorFipe.Location = new Point(125, 180);
            txtValorFipe.Name = "txtValorFipe";
            txtValorFipe.Size = new Size(119, 23);
            txtValorFipe.TabIndex = 16;
            txtValorFipe.TextChanged += txtValorFipe_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 183);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 19;
            label7.Text = "Valor da Fipe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 212);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 20;
            label8.Text = "Valor de Venda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 245);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 21;
            label9.Text = "Observacoes";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(125, 242);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(119, 23);
            txtObservacoes.TabIndex = 22;
            txtObservacoes.TextChanged += txtObservacoes_TextChanged;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Location = new Point(336, 38);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.Size = new Size(452, 400);
            dgvVeiculos.TabIndex = 23;
            dgvVeiculos.CellContentClick += dgvVeiculos_CellContentClick;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(123, 93);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(121, 23);
            txtModelo.TabIndex = 24;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(123, 64);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 25;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(dgvVeiculos);
            Controls.Add(txtObservacoes);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtValorFipe);
            Controls.Add(txtValorVenda);
            Controls.Add(txtAnoModelo);
            Controls.Add(txtAnoFabricacao);
            Controls.Add(txtChassi);
            Controls.Add(txtPlaca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicionar);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnLimpar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPlaca;
        private TextBox txtChassi;
        private TextBox txtAnoFabricacao;
        private TextBox txtAnoModelo;
        private TextBox txtValorVenda;
        private TextBox txtValorFipe;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtObservacoes;
        private DataGridView dgvVeiculos;
        private TextBox txtModelo;
        private TextBox txtMarca;
    }
}