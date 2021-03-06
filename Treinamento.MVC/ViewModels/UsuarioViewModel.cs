﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int IdUsuario { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        [Required(ErrorMessage = "É necessário preencher o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "É necessário preencher a senha")]
        [MinLength(8, ErrorMessage = "A senha precisa ter no mínimo {0} caracteres")]
        [MaxLength(24, ErrorMessage = "A senha precisa ter no máximo {0} caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É necessário preencher um e-mail")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        public virtual IEnumerable<TarefaViewModel> Tarefas { get; set; }

        public virtual IEnumerable<ProjetoViewModel> Projetos { get; set; }

        public virtual IEnumerable<EnderecoViewModel> Enderecos { get; set; }

        public virtual IEnumerable<ContatoViewModel> Contatos { get; set; }

        public virtual IEnumerable<ArquivoViewModel> Arquivos { get; set; }
    }
}