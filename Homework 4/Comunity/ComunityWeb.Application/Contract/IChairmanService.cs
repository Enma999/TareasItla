using ComunityWeb.Application.DTOs.Enums;

namespace ComunityWeb.Application.Contract
{
    public interface IChairmanService
    {
        Task DeleteAsync(int id);
        Task<List<ChairmanDTO>> GetAll();
        Task<ChairmanDTO> GetById(int id);
    }
}