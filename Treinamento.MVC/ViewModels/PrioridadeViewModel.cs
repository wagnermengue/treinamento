using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinamento.MVC.ViewModels
{
    public class PrioridadeViewModel
    {
        [Key]
        public int IdPrioridade { get; set; }

        [Required(ErrorMessage = "Preencha a descrição")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public virtual IEnumerable<TarefaViewModel> Tarefas { get; set; }
    }
}