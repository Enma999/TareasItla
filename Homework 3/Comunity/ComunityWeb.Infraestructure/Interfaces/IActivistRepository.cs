using ComunityWeb.Infraestructure.Models;

namespace ComunityWeb.Infraestructure.Interfaces
{
    public interface IActivistRepository
    {
        void DeleteByIdAsync(int id);
        Task<List<ActivistModel>> GetAllAsync();
        Task<List<ActivistModel>> GetByIdAsync(int id);
        Task<ActivistModel> GetByNameAsync(string name);
    }
}