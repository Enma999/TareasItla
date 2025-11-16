using ComunityWeb.Application.DTOs.CreateDTO;
using ComunityWeb.Application.DTOs.Enums;

namespace ComunityWeb.Application.Contract
{
    public interface IMemberService
    {
        Task<MemberDTO> AddAsync(MemberCDTO entity);
        Task DeleteAsync(int ID);
        Task<List<MemberDTO>> GetAll();
        Task<MemberDTO> GetById(int ID);
        Task<List<MemberDTO>> GetByNameAsync(string name);
        Task<MemberDTO> UpdateAsync(MemberDTO entity, int ID);
    }
}