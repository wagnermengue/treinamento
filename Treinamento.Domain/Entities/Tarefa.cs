using System;

namespace Treinamento.Domain.Entities
{
    public class Tarefa
    {
        public int IdTarefa { get; set; }
        public int IdProjeto { get; set; }
        public virtual Projeto Projeto { get; set; }
        public string Descricao { get; set; }
        public int IdPrioridade { get; set; }
        public virtual Prioridade Prioridade { get; set; }
        public int IdStatus { get; set; }
        public virtual Status Status { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataRealizada { get; set; }
        public int Responsavel { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public int Peso { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
