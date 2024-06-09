using Domain.DTOs.ProdutorDTO;
using Domain.Models;

namespace Domain.Interfaces.IService
{
    public interface IProdutorService
    {
        Task<List<ProdutorModel>> ListarProdutores();
        Task<ProdutorModel> BuscarProdutorPorId(int idProdutor);
        Task<ProdutorModel> CriarProdutor(ProdutorCriacaoDTO produtorDto);
        Task<ProdutorModel> EditarProdutor(ProdutorEdicaoDTO produtorDto);
        Task<bool> ExcluirProdutor(int idProdutor);
    }

}
