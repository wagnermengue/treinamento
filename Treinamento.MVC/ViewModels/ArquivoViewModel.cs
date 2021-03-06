﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class ArquivoViewModel
    {
        [Key]
        public int IdArquivo { get; set; }

        public int IdProjeto { get; set; }

        public virtual ProjetoViewModel Projeto { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo para o nome é de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o caminho")]
        public string Caminho { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
    }
}