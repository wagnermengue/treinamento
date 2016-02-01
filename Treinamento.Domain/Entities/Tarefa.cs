using System;

namespace Treinamento.Domain.Entities
{
    public class Tarefa
    {
        public int IdTarefa { get; set; }
        public int IdProjeto { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }
        public int Status { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataRealizada { get; set; }
        public int Responsavel { get; set; }
        public int Peso { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdUsuario { get; set; }
    }
}
