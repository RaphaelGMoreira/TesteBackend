using Microsoft.AspNetCore.Mvc;
using PostoGasolina.Entity;
using PostoGasolina.Repositories;
using System.Threading.Tasks;

namespace PostoGasolina.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoController(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduto(Produto produto)
        {
            await _produtoRepository.AddAsync(produto);
            return Ok(produto);

        }
        
    }
}
