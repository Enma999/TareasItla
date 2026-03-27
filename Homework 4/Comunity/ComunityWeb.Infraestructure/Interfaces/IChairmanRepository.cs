using ComunityWeb.Infraestructure.Models;

namespace ComunityWeb.Infraestructure.Interfaces
{
    public interface IChairmanRepository : IBaseRepository<ChairmanModel>
    {
        Task Add(ChairmanModel chairman);
        Task Delete(int id);
        Task<List<ChairmanModel>> GetAll();
        Task GetByContainName(string name);
        Task<ChairmanModel> GetById(int id);
        Task<ChairmanModel> GetByName(string name);
        Task Update(ChairmanModel chairman);
    }
}