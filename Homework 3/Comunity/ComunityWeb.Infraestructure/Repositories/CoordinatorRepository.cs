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
    public class CoordinatorRepository : BaseRepository<CoordinatorModel>, ICoordinatorRepository
    {
        public CoordinatorRepository(TaskContext dbcontext) : base(dbcontext)
        {
        }

        public async Task<CoordinatorModel> GetById(int id)
        {
            return await _context.Coordinators.FindAsync(id);
        }

        public async Task<List<CoordinatorModel>> GetAll()
        {
            return await _context.Coordinators.ToListAsync();
        }

        public async Task Add(CoordinatorModel coordinator)
        {
            _context.Coordinators.Add(coordinator);
            await _context.SaveChangesAsync();
        }

        public async Task Update(CoordinatorModel coordinator)
        {
            _context.Coordinators.Update(coordinator);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public async Task<CoordinatorModel> GetByName(string name)
        {
            return await _context.Coordinators.FirstOrDefaultAsync(m => m.Name == name);
        }

    }
}
