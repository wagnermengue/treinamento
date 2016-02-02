using System;
using System.Collections.Generic;

namespace Treinamento.Domain.Entities
{
    public class Status
    {
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<Tarefa> Tarefas { get; set; }
        public virtual IEnumerable<Projeto> Projetos { get; set; }
    }
}
