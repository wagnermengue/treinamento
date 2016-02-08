﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class Status
    {
        [Key]
        public int IdStatus { get; set; }

        [Required(ErrorMessage = "É necessário preencher a descrição")]
        [MinLength(5, ErrorMessage = "Número mínimo de caracteres é {0}")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        //public virtual IEnumerable<Tarefa> Tarefas { get; set; }

        //public virtual IEnumerable<Projeto> Projetos { get; set; }
    }
}