using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories.Interfaces
{
    public interface IChamadoRepository
    {
        IEnumerable<Chamado> Chamados { get; }
        /*
        IEnumerable<Chamado> ChamadosPorId(int chamadoId);
        IEnumerable<Chamado> ChamadosPorCategoria { get; }
        IEnumerable<Chamado> ChamadosPorCliente { get; }
        IEnumerable<Chamado> ChamadosPorFuncionario { get; }
        IEnumerable<Chamado> ChamadosPorPrioridade { get; }
        IEnumerable<Chamado> ChamadoPorSituacao { get; }
        IEnumerable<Chamado> ChamadoPorDescricao(string chamadoDescricao);
        */
    }
}
