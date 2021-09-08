using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Repositories
{
    public interface ICateoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
