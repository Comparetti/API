using Data.Context;
using Domain.DTOs.ConsumidorDTO;
using Domain.Interfaces.IService;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.Service.Consumidor
{
    public class ConsumidorService : IConsumidorService
    {
        private readonly AppDbContext _context;
        public ConsumidorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ConsumidorModel>> ListarConsumidores()
        {
            return await _context.Consumidores.ToListAsync();
        }

        public async Task<ConsumidorModel> BuscarConsumidorPorId(int id)
        {
            var consumidor = await _context.Consumidores.FindAsync(id);
            if (consumidor == null)
                return null;

            return consumidor;
        }

        public async Task<ConsumidorModel> CriarConsumidor(ConsumidorCriacaoDTO consumidorDto)
        {
            var consumidor = new ConsumidorModel
            {
                Nome = consumidorDto.Nome,
                Sobrenome = consumidorDto.Sobrenome,
                ConsumoEnergia = consumidorDto.ConsumoEnergia,
                PreferenciaEnergia = consumidorDto.PreferenciaEnergia,
                DespesaMensalEnergia = consumidorDto.DespesaMensalEnergia,
                ContratoAtivo = consumidorDto.ContratoAtivo
            };

            _context.Consumidores.Add(consumidor);
            await _context.SaveChangesAsync();

            return consumidor;
        }

        public async Task<ConsumidorModel> EditarConsumidor(ConsumidorEdicaoDTO consumidorDto)
        {
            var consumidor = await _context.Consumidores.FindAsync(consumidorDto.Id);
            if (consumidor == null)
                return null;

            consumidor.Nome = consumidorDto.Nome;
            consumidor.Sobrenome = consumidorDto.Sobrenome;
            consumidor.ConsumoEnergia = consumidorDto.ConsumoEnergia;
            consumidor.PreferenciaEnergia = consumidorDto.PreferenciaEnergia;
            consumidor.DespesaMensalEnergia = consumidorDto.DespesaMensalEnergia;
            consumidor.ContratoAtivo = consumidorDto.ContratoAtivo;

            await _context.SaveChangesAsync();

            return consumidor;
        }


        public async Task<bool> ExcluirConsumidor(int id)
        {
            var consumidor = await _context.Consumidores.FindAsync(id);
            if (consumidor == null)
                return false;

            _context.Consumidores.Remove(consumidor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
