using System;

namespace MinhaEmpresa.Apresentacao
{
    public class Funcionario // Declara a classe pública chamada Funcionario.
    {
        // Propriedades que representam os identificadores da tabela.
        // copiei do PDF da AF disponibilizado no AVA.
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Departamento { get; set; }
    }
}
