using MinhaEmpresa.Apresentacao;
using MySql.Data.MySqlClient;

namespace MinhaEmpresa.Dados
{
    public class FuncionarioDAO
    {
        //Aqui muito importante falar, copiei a List<Funcionario> e o método RemoverFuncionario da AF disponibilizada...
        //... no AVA, porém, neste projeto, não inclui o método adicionar funcionários, pois achei mais conveniente colocá-lo no windows form de adicionar funcionario *FrmNovo*

        // Método que retorna uma lista de todos os funcionários cadastrados no banco... instanciei a mesma no método Atualizar() do Form1 (form principal)
        public List<Funcionario> ListarFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            
            using(MySqlConnection conn = Conexao.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM funcionario"; // Comando SQL para buscar todos os registros da tabela funcionario

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader Reader = cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            // Cria um novo objeto Funcionario e preenche os dados vindos do banco
                            Funcionario funcionario = new Funcionario
                            {
                                ID = Reader.GetInt32("ID"),
                                Nome = Reader.GetString("Nome"),
                                Cargo = Reader.GetString("Cargo"),
                                Salario = Reader.GetDecimal("Salario"),
                                DataContratacao = Reader.GetDateTime("DataContratacao"),
                                Departamento = Reader.GetString("Departamento"),
                            };
                            funcionarios.Add(funcionario); // Adiciona o funcionário à lista
                        }
                    }
                }
            }
            return funcionarios; // Retorna a lista completa de funcionários
        }

        // Método que remove um funcionário com base no ID informado... invoquei este mesmo método via instancia igual o ListarFuncionarios, mas dessa vez como resposta ao evento "btnExcluir_Click"
        public void RemoverFuncionario(int id)
        {
            using(MySqlConnection conn = Conexao.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Funcionario WHERE ID = @ID"; // Comando SQL para remover um funcionário específico

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id); // Define o valor do parâmetro ID na query
                    cmd.ExecuteNonQuery(); // Executa o comando de exclusão no banco
                }
            }
        }
    }
}
