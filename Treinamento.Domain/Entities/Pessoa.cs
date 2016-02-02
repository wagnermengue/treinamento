using System;

namespace Treinamento.Domain.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        //public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
