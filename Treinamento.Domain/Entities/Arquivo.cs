using System;

namespace Treinamento.Domain.Entities
{
    public class Arquivo
    {
        public int IdArquivo { get; set; }
        public int IdProjeto { get; set; }
        public virtual Projeto Projeto { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
