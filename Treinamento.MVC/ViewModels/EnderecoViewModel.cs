using System;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int IdEndereco { get; set; }

        public int IdPessoa { get; set; }

        //public virtual Pessoa Pessoa { get; set; }

        [Required(ErrorMessage = "É necessário preencher o CEP")]
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        //public virtual Usuario Usuario { get; set; }
    }
}