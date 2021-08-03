using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Repositories.Interfaces;

namespace TiTech.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepository _chamadoRepository;
        private readonly ISituacaoRepository _situacaoRepository;

        public ChamadoController(IChamadoRepository chamadoRepository, ISituacaoRepository situacaoRepository)
        {
            _chamadoRepository = chamadoRepository;
            _situacaoRepository = situacaoRepository;
        }
        public IActionResult List()
        {
            var chamados = _chamadoRepository.Chamados;
            return View(chamados);
        }
    }
}
