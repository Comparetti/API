using Domain.DTOs.ProdutorDTO;
using Domain.Interfaces.IService;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Thunders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutorController : ControllerBase
    {
        private readonly IProdutorService _produtorService;

        public ProdutorController(IProdutorService produtorService)
        {
            _produtorService = produtorService;
        }

        [HttpGet("ListarProdutores")]
        public async Task<ActionResult<List<ProdutorModel>>> ListarProdutores()
        {
            var produtores = await _produtorService.ListarProdutores();
            return Ok(produtores);
        }

        [HttpGet("BuscarProdutorPorId/{id}")]
        public async Task<ActionResult<ProdutorModel>> BuscarProdutorPorId(int id)
        {
            var produtor = await _produtorService.BuscarProdutorPorId(id);
            if (produtor == null)
                return NotFound("Produtor não encontrado.");

            return Ok(produtor);
        }

        [HttpPost("CriarProdutor")]
        public async Task<ActionResult<ProdutorModel>> CriarProdutor(ProdutorCriacaoDTO produtorDto)
        {
            var produtor = await _produtorService.CriarProdutor(produtorDto);
            return Ok(produtor);
        }

        [HttpPut("EditarProdutor")]
        public async Task<ActionResult<ProdutorModel>> EditarProdutor(ProdutorEdicaoDTO produtorDto)
        {
            var produtor = await _produtorService.EditarProdutor(produtorDto);
            if (produtor == null)
                return NotFound("Produtor não encontrado.");

            return Ok(produtor);
        }

        [HttpDelete("ExcluirProdutor/{id}")]
        public async Task<IActionResult> ExcluirProdutor(int id)
        {
            var sucesso = await _produtorService.ExcluirProdutor(id);
            if (!sucesso)
                return NotFound("Produtor não encontrado.");

            return NoContent();
        }
    }

}
