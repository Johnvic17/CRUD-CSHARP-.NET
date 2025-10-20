using MinhaEmpresa.Dados;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MinhaEmpresaAF
{
    public partial class frmModificar : Form
    {
        MySqlConnection conn = Conexao.GetConnection(); // Cria uma conexão com o banco de dados

        public frmModificar()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }

        // Botão responsável por atualizar as informações de um funcionário no banco de dados
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ret; // Variável para armazenar o retorno da execução do comando SQL
            try
            {
                using (MySqlConnection conn = Conexao.GetConnection())
                {
                    conn.Open(); // Abre a conexão

                    // Comando SQL para atualizar os dados do funcionário
                    string query = @"UPDATE Funcionario SET Nome= @Nome, Cargo= @Cargo, Salario= @Salario, DataContratacao= @DataContratacao, Departamento= @Departamento WHERE ID=@ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Define os parâmetros da query com os valores dos campos do formulário
                        cmd.Parameters.AddWithValue("@ID", txtId.Text);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                        cmd.Parameters.AddWithValue("@Departamento", txtDepartamento.Text);
                        cmd.Parameters.AddWithValue("@DataContratacao", valueDate.Value);

                        // Tenta converter o salário digitado em número decimal
                        if (decimal.TryParse(txtSalario.Text.Replace(".", ","), out decimal salario))
                        {
                            cmd.Parameters.AddWithValue("@Salario", salario);
                        }
                        else
                        {
                            MessageBox.Show("O valor do Salário não é um número válido.");
                        }

                        // Executa o comando SQL e retorna o número de linhas afetadas
                        ret = cmd.ExecuteNonQuery();

                        // Se ao menos uma linha foi atualizada, mostra sucesso
                        if (ret > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso.");
                            Close(); // Fecha o formulário após a atualização
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar registro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        // Evento que ocorre quando o formulário é carregado
        private void frmModificar_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        // As propriedades abaixo permitem acessar e modificar os valores dos campos do formulário externamente
        public string IdText
        {
            get
            {
                return this.txtId.Text;
            }
            set
            {
                this.txtId.Text = value;
            }
        }
        public string NomeText
        {
            get
            {
                return this.txtNome.Text;
            }
            set
            {
                this.txtNome.Text = value;
            }
        }
        public string CargoText
        {
            get
            {
                return this.txtCargo.Text;
            }
            set
            {
                this.txtCargo.Text = value;
            }
        }
        public string SalarioText
        {
            get
            {
                return this.txtSalario.Text;
            }
            set
            {
                this.txtSalario.Text = value;
            }
        }
        public string DateText
        {
            get
            {
                return this.valueDate.Value.ToString("yyyy-MM-dd"); // Retorna a data formatada
            }
            set
            {
                // Tenta converter a string recebida em uma data válida
                if (DateTime.TryParse(value, out DateTime date))
                {
                    this.valueDate.Value = date;
                }
                else
                {
                    MessageBox.Show("Data inválida."); // Mostra erro caso a conversão falhe
                }
            }
        }
        public string DepartamentoText
        {
            get
            {
                return this.txtDepartamento.Text;
            }
            set
            {
                this.txtDepartamento.Text = value;
            }
        }

    }
}
