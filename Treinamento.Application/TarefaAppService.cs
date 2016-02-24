using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class TarefaAppService : AppServiceBase<Tarefa>, ITarefaAppService
    {
        private readonly ITarefaService _tarefaService;

        public TarefaAppService(ITarefaService tarefaService)
            :base(tarefaService)
        {
            _tarefaService = tarefaService;
        }
    }
}
