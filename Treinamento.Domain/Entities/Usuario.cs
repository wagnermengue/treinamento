using System;

namespace Treinamento.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
