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
    public class ActivistRepository : BaseRepository<ActivistModel>, IActivistRepository
    {
        public ActivistRepository(TaskContext dbcontext) : base(dbcontext)
        {
        }

        public async Task<ActivistModel> GetByNameAsync(string name)
        {
            return await _context.Activists.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<List<ActivistModel>> GetAllAsync()
        {
            return _context.Activists.ToList();
        }

        public async Task<List<ActivistModel>> GetByIdAsync(int id)
        {
            return _context.Activists.ToList();
        }

        public async void DeleteByIdAsync(int id)
        {
            return;

        }
    }
}
