using Data.Context;
using Domain.DTOs.ProdutorDTO;
using Domain.Interfaces.IService;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.Service.Produtor
{
    public class ProdutorService : IProdutorService
    {
        private readonly AppDbContext _context;
        public ProdutorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProdutorModel>> ListarProdutores()
        {
            return await _context.Produtores.ToListAsync();
        }

        public async Task<ProdutorModel> BuscarProdutorPorId(int id)
        {
            var produtor = await _context.Produtores.FindAsync(id);
            if (produtor == null)
                return null;

            return produtor;
        }

        public async Task<ProdutorModel> CriarProdutor(ProdutorCriacaoDTO produtorDto)
        {
            var produtor = new ProdutorModel
            {
                Nome = produtorDto.Nome,
                Sobrenome = produtorDto.Sobrenome,
                CapacidadeProducao = produtorDto.CapacidadeProducao,
                TipoEnergia = produtorDto.TipoEnergia,
                Localizacao = produtorDto.Localizacao,
                DataInicioOperacao = produtorDto.DataInicioOperacao
            };

            _context.Produtores.Add(produtor);
            await _context.SaveChangesAsync();

            return produtor;
        }

        public async Task<ProdutorModel> EditarProdutor(ProdutorEdicaoDTO produtorDto)
        {
            var produtor = await _context.Produtores.FindAsync(produtorDto.Id);
            if (produtor == null)
                return null;

            produtor.Nome = produtorDto.Nome;
            produtor.Sobrenome = produtorDto.Sobrenome;
            produtor.CapacidadeProducao = produtorDto.CapacidadeProducao;
            produtor.TipoEnergia = produtorDto.TipoEnergia;
            produtor.Localizacao = produtorDto.Localizacao;
            produtor.DataInicioOperacao = produtorDto.DataInicioOperacao;
            produtor.Ativo = produtorDto.Ativo;

            await _context.SaveChangesAsync();

            return produtor;
        }

        public async Task<bool> ExcluirProdutor(int id)
        {
            var produtor = await _context.Produtores.FindAsync(id);
            if (produtor == null)
                return false;

            _context.Produtores.Remove(produtor);
            await _context.SaveChangesAsync();
            return true;
        }
    }

}
