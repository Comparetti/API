using Domain.DTOs.ConsumidorDTO;
using Domain.Interfaces.IService;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Thunders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumidorController : ControllerBase
    {
        private readonly IConsumidorService _consumidorService;

        public ConsumidorController(IConsumidorService consumidorService)
        {
            _consumidorService = consumidorService;
        }

        [HttpGet("ListarConsumidores")]
        public async Task<ActionResult<List<ConsumidorModel>>> ListarConsumidores()
        {
            var consumidores = await _consumidorService.ListarConsumidores();
            return Ok(consumidores);
        }

        [HttpGet("BuscarConsumidorPorId/{id}")]
        public async Task<ActionResult<ConsumidorModel>> BuscarConsumidorPorId(int id)
        {
            var consumidor = await _consumidorService.BuscarConsumidorPorId(id);
            if (consumidor == null)
                return NotFound("Consumidor não encontrado.");

            return Ok(consumidor);
        }

        [HttpPost("CriarConsumidor")]
        public async Task<ActionResult<ConsumidorModel>> CriarConsumidor(ConsumidorCriacaoDTO consumidorDto)
        {
            var consumidor = await _consumidorService.CriarConsumidor(consumidorDto);
            return Ok(consumidor);
        }

        [HttpPut("EditarConsumidor")]
        public async Task<ActionResult<ConsumidorModel>> EditarConsumidor(ConsumidorEdicaoDTO consumidorDto)
        {
            var consumidor = await _consumidorService.EditarConsumidor(consumidorDto);
            if (consumidor == null)
                return NotFound("Consumidor não encontrado.");

            return Ok(consumidor);
        }

        [HttpDelete("ExcluirConsumidor/{id}")]
        public async Task<IActionResult> ExcluirConsumidor(int id)
        {
            var sucesso = await _consumidorService.ExcluirConsumidor(id);
            if (!sucesso)
                return NotFound("Consumidor não encontrado.");

            return NoContent();
        }
    }

}
