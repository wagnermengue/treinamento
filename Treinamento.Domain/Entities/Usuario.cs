using System;
using System.Collections.Generic;

namespace Treinamento.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        //public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public virtual IEnumerable<Tarefa> Tarefas { get; set; }
        public virtual IEnumerable<Projeto> Projetos { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; }
        public virtual IEnumerable<Contato> Contatos { get; set; }
        public virtual IEnumerable<Arquivo> Arquivos { get; set; }
    }
}
