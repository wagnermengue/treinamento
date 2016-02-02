using System;
using System.Collections.Generic;

namespace Treinamento.Domain.Entities
{
    public class TipoContato
    {
        public int IdTipoContato { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<Contato> Contatos { get; set; }
    }
}
