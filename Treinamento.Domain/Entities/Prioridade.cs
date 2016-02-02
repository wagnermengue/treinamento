using System;
using System.Collections.Generic;

namespace Treinamento.Domain.Entities
{
    public class Prioridade
    {
        public int IdPrioridade { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<Tarefa> Tarefas { get; set; }
    }
}
