using Core.Domain.Models;
using Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return null;    
        }
    }
}
