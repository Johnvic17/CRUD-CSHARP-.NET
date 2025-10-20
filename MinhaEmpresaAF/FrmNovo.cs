using MinhaEmpresa.Dados;
using MySql.Data.MySqlClient;

namespace MinhaEmpresaAF
{
    public partial class FrmNovo : Form
    {
        MySqlConnection conn = Conexao.GetConnection(); // Cria uma conexão com o banco de dados
        private FuncionarioDAO _funcionarioDAO; // Objeto responsável pelas operações no banco

        public FrmNovo()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            _funcionarioDAO = new FuncionarioDAO(); // Instancia o DAO que será usado para acessar os dados
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }

        // Botão responsável por adicionar um novo funcionário ao banco de dados
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int ret; // Variável usada para verificar se o comando SQL foi executado com sucesso
            try
            { 
                using (MySqlConnection conn = Conexao.GetConnection()) // Cria uma nova conexão temporária com o banco
                {
                    conn.Open(); // Abre a conexão

                    // Comando SQL que insere um novo registro na tabela Funcionario
                    string query = "INSERT INTO Funcionario (Nome, Cargo, Salario, DataContratacao, Departamento) VALUES (@Nome, @Cargo, @Salario, @DataContratacao, @Departamento)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) // Cria o comando SQL com a conexão
                    {
                        // Define os parâmetros da query com os valores informados pelo usuário
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                        cmd.Parameters.AddWithValue("@Departamento", txtDepartamento.Text);

                        cmd.Parameters.AddWithValue("@DataContratacao", valueDate.Value);

                        // Tenta converter o salário digitado em número decimal
                        if (decimal.TryParse(txtSalario.Text.Replace(".", ","), out decimal salario))
                        {
                            cmd.Parameters.AddWithValue("@Salario", salario);
                        } else
                        {
                            MessageBox.Show("O valor do Salário não é um número válido."); // Mostra erro caso o valor não seja numérico
                        }

                        ret = cmd.ExecuteNonQuery(); // Executa o comando SQL e retorna o número de linhas afetadas

                        // Se o comando afetou alguma linha, exibe mensagem de sucesso
                        if (ret > 0)
                        {
                            MessageBox.Show("Registro inserido com sucesso.");
                            Close(); // Fecha o formulário após inserir o registro
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir registro."); // Exibe mensagem caso a inserção falhe
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
    }
}
