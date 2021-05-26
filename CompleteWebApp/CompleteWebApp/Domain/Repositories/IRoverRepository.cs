using CompleteWebApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteWebApp.Domain.Repositories
{
    public interface IRoverRepository
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetRoverByIdAsync(int id);
    }
}
