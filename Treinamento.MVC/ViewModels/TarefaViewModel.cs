using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class TarefaViewModel
    {
        [Key]
        public int IdTarefa { get; set; }

        public int IdProjeto { get; set; }

        public virtual ProjetoViewModel Projeto { get; set; }

        [Required(ErrorMessage = "É necessário preencher a descrição")]
        [MinLength(5, ErrorMessage = "Número mínimo de caracteres é {0}")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public int IdPrioridade { get; set; }

        public virtual PrioridadeViewModel Prioridade { get; set; }

        public int IdStatus { get; set; }

        public virtual StatusViewModel Status { get; set; }

        public DateTime DataPrevista { get; set; }

        public DateTime DataRealizada { get; set; }

        public int Responsavel { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public int Peso { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAtualizacao { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
    }
}