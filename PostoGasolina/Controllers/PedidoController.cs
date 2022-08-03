using Microsoft.AspNetCore.Mvc;
using PostoGasolina.Entity;
using PostoGasolina.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {

        private readonly PedidoRepository _pedidoRepository;

        public PedidoController(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPedido(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
            return Ok(pedido);

        }

    }
}
