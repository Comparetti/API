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
            return Ok(produtor);
        }

        [HttpDelete("ExcluirProdutor/{id}")]
        public async Task<ActionResult> ExcluirProdutor(int id)
        {
            await _produtorService.ExcluirProdutor(id);
            return Ok();
        }
    }

}
