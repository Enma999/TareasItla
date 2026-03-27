using ComunityWeb.Application.DTOs.Enums;

namespace ComunityWeb.Application.Contract
{
    public interface IActivistService
    {
        Task DeleteAsync(int Id);
        Task<List<ActivistDTO>> GetAll();
        Task<ActivistDTO> GetById(int id);
        Task<ActivistDTO> UpdateAsync(ActivistDTO entity, int id);
    }
}