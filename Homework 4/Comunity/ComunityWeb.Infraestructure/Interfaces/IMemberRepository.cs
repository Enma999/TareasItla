using ComunityWeb.Infraestructure.Models;

namespace ComunityWeb.Infraestructure.Interfaces
{
    public interface IMemberRepository : IBaseRepository<MemberModel>
    {
        Task Add(MemberModel member);
        Task Delete(int id);
        Task<List<MemberModel>> GetAll();
        Task GetAllByContaineName(string name);
        Task<List<MemberModel>> GetByCountry(string country);
        Task<MemberModel> GetById(int id);
        Task<MemberModel> GetAllByContainName(string name);
        Task Update(MemberModel member);
    }
}