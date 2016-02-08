using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class StatusViewModel
    {
        [Key]
        public int IdStatus { get; set; }

        [Required(ErrorMessage = "É necessário preencher a descrição")]
        [MinLength(5, ErrorMessage = "Número mínimo de caracteres é {0}")]
        [MaxLength(150, ErrorMessage = "Número máximo de caracteres é {0}")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public virtual IEnumerable<TarefaViewModel> Tarefas { get; set; }

        public virtual IEnumerable<ProjetoViewModel> Projetos { get; set; }
    }
}