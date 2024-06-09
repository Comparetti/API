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
            return Ok(consumidor);
        }

        [HttpDelete("ExcluirConsumidor/{id}")]
        public async Task<ActionResult> ExcluirConsumidor(int id)
        {
            await _consumidorService.ExcluirConsumidor(id);
            return Ok();
        }
    }

}
