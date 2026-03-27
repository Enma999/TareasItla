using ComunityWeb.Infraestructure.Models;

namespace ComunityWeb.Infraestructure.Interfaces
{
    public interface ICoordinatorRepository : IBaseRepository<CoordinatorModel>
    {
        Task Add(CoordinatorModel coordinator);
        Task Delete(int id);
        Task<List<CoordinatorModel>> GetAll();
        object GetAllByContainName(string name);
        Task<CoordinatorModel> GetById(int id);
        Task<CoordinatorModel> GetByName(string name);
        Task Update(CoordinatorModel coordinator);
    }
}