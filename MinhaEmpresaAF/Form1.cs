using MinhaEmpresa.Dados;
using MySql.Data.MySqlClient;

namespace MinhaEmpresaAF
{
    public partial class Form1 : Form // Classe parcial que representa o formulário principal da aplicação
    {
        MySqlConnection conn = Conexao.GetConnection(); // Cria uma conexão com o banco de dados
        private FuncionarioDAO _funcionarioDAO; // Declara o objeto responsável pelas operações com o banco
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            _funcionarioDAO = new FuncionarioDAO(); // Instancia o DAO que será usado para acessar os dados
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open(); // Abre a conexão com o banco de dados quando o formulário é carregado
        }

        public void Atualizar()
        {
            try
            {
                var listarFuncionarios = _funcionarioDAO.ListarFuncionarios(); // Busca todos os funcionários
                gvFuncionarios.DataSource = listarFuncionarios; // Exibe os dados no DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            Atualizar(); // Atualiza os dados sempre que o formulário é ativado
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmNovo frmNovo = new FrmNovo(); // Cria uma nova instância do formulário de cadastro
            frmNovo.Show(); // Exibe o formulário
        }

        // Botão que abre o formulário de modificação dos dados de um funcionário selecionado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = gvFuncionarios.CurrentRow.Index; // Pega o índice da linha selecionada no DataGridView

            frmModificar FrmModificar = new frmModificar(); // Cria uma nova instância do formulário de modificação
            FrmModificar.Show(); // Exibe o formulário

            // Passa os dados da linha selecionada para os campos do formulário de modificação
            FrmModificar.IdText = gvFuncionarios.Rows[index].Cells[0].Value.ToString();
            FrmModificar.NomeText = gvFuncionarios.Rows[index].Cells[1].Value.ToString();
            FrmModificar.CargoText = gvFuncionarios.Rows[index].Cells[2].Value.ToString();
            FrmModificar.SalarioText = gvFuncionarios.Rows[index].Cells[3].Value.ToString();
            FrmModificar.DateText = gvFuncionarios.Rows[index].Cells[4].Value.ToString();
            FrmModificar.DepartamentoText = gvFuncionarios.Rows[index].Cells[5].Value.ToString();
        }

        // Botão que exclui o funcionário selecionado da tabela
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = gvFuncionarios.CurrentRow.Index; // Pega o índice da linha selecionada
            int id = Convert.ToInt32(gvFuncionarios.Rows[index].Cells[0].Value); // Obtém o ID do funcionário selecionado

            var confirm = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _funcionarioDAO.RemoverFuncionario(id); // Chama o método de remoção no banco de dados
                    MessageBox.Show("Usuário removido com sucesso!"); // Exibe mensagem de sucesso

                    Atualizar(); // Atualiza a lista de funcionários após a exclusão
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[ERRO]: " + ex.Message);
                }
            }
        }
    }
}
