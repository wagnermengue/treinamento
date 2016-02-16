using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class TarefaService : ServiceBase<Tarefa>, ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
            :base(tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }
    }
}
