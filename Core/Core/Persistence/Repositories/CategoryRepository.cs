using Core.Domain.Models;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICateoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) 
        { 
            
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
