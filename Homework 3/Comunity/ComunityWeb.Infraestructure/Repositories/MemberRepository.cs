using ComunityWeb.Infraestructure.Context;
using ComunityWeb.Infraestructure.Core;
using ComunityWeb.Infraestructure.Interfaces;
using ComunityWeb.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Repositories
{
    public class MemberRepository : BaseRepository<MemberModel>, IMemberRepository
    {

        public MemberRepository(TaskContext taskContext) : base(taskContext)
        {
        }

        public async Task<MemberModel> GetById(int id)
        {
            return await _context.Members.FindAsync(id);
        }


        public async Task<List<MemberModel>> GetAll()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task Add(MemberModel member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
        }

        public async Task Update(MemberModel member)
        {
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var member = await _context.Members.FindAsync(id);

            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<MemberModel> GetByName(string name)
        {
            return await _context.Members.FirstOrDefaultAsync(m => m.Name.Contains(name));
        }

        public async Task<List<MemberModel>> GetByCountry(string country)
        {
            return await _context.Members.Where(m => m.Country.Contains(country)).ToListAsync();
        }
    }
}
