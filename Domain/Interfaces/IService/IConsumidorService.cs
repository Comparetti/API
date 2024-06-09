using Domain.DTOs.ConsumidorDTO;
using Domain.Models;

namespace Domain.Interfaces.IService
{
    public interface IConsumidorService
    {
        Task<List<ConsumidorModel>> ListarConsumidores();
        Task<ConsumidorModel> BuscarConsumidorPorId(int idConsumidor);
        Task<ConsumidorModel> CriarConsumidor(ConsumidorCriacaoDTO consumidorDto);
        Task<ConsumidorModel> EditarConsumidor(ConsumidorEdicaoDTO consumidorDto);
        Task<bool> ExcluirConsumidor(int idConsumidor);
    }

}
