using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class ProjetoViewModel
    {
        [Key]
        public int IdProjeto { get; set; }

        [Required(ErrorMessage = "É necessário preencher a descrição")]
        [MinLength(5, ErrorMessage = "Número mínimo de caracteres é {0}")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }


        public int IdPessoa { get; set; }
        //public virtual Pessoa Pessoa { get; set; }

        [DisplayName("Data previsa")]
        public DateTime DataPrevista { get; set; }

        [DisplayName("Data realizada")]
        public DateTime DataRealizada { get; set; }

        public int IdStatus { get; set; }
        //public virtual Status Status { get; set; }

        public int Responsavel { get; set; }
        //public virtual Pessoa PessoaResponsavel { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }
        //public virtual Usuario Usuario { get; set; }
    }
}