using System;

namespace Treinamento.Domain.Entities
{
    public class Projeto
    {
        public int IdProjeto { get; set; }
        public string Descricao { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataRealizada { get; set; }
        public int Status { get; set; }
        public int Responsavel { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdUsuario { get; set; }
    }
}
