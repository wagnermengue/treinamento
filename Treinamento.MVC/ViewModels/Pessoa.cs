using System;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [MinLength(2, ErrorMessage = "Número mínimo de caracteres é {0}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o sobrenome")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [MinLength(2, ErrorMessage = "Número mínimo de caracteres é {0}")]
        public string Sobrenome { get; set; }

        public string Identidade { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        //public virtual Usuario Usuario { get; set; }
    }
}