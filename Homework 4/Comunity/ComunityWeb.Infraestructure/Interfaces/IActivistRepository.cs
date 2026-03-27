using ComunityWeb.Infraestructure.Models;

namespace ComunityWeb.Infraestructure.Interfaces
{
    public interface IActivistRepository : IBaseRepository<ActivistModel>
    {
        void DeleteByIdAsync(int id);
        Task<List<ActivistModel>> GetAllAsync();
        Task GetAllByContainName(string name);
        Task<List<ActivistModel>> GetByIdAsync(int id);
        Task<ActivistModel> GetByNameAsync(string name);
    }
}