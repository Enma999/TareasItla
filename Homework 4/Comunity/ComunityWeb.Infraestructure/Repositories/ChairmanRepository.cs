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
    public class ChairmanRepository : BaseRepository<ChairmanModel>, IChairmanRepository
    {
        public ChairmanRepository(TaskContext taskContext) : base(taskContext)
        {
        }

        public async Task<ChairmanModel> GetById(int id)
        {
            return await _context.Chairman.FindAsync(id);
        }

        public async Task<List<ChairmanModel>> GetAll()
        {
            return await _context.Chairman.ToListAsync();
        }

        public async Task Add(ChairmanModel chairman)
        {
            _context.Chairman.Add(chairman);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ChairmanModel chairman)
        {
            _context.Chairman.Update(chairman);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public async Task<ChairmanModel> GetByName(string name)
        {
            return await _context.Chairman.FirstOrDefaultAsync(m => m.Name == name);
        }
    }
}
