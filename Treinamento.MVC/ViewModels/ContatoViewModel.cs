using System;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class ContatoViewModel
    {
        [Key]
        public int IdContato { get; set; }

        public int IdPessoa { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        [Required(ErrorMessage = "Preencha a descrição")]
        [MaxLength(60, ErrorMessage = "Número máximo de caracteres é {0}")]
        [MinLength(2, ErrorMessage = "Número mínimo de caracteres é {0}")]
        public string Descricao { get; set; }

        public int IdTipo { get; set; }

        public virtual TipoContatoViewModel TipoContato { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
    }
}