using ComunityWeb.Application.DTOs.Enums;

namespace ComunityWeb.Application.Contract
{
    public interface ICoordinatorService
    {
        Task<List<CoordinatorDTO>> GetAll();
        Task<CoordinatorDTO> GetById(int id);
        Task<CoordinatorDTO> GetByNameAsync(string name);
    }
}