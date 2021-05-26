using CompleteWebApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteWebApp.Domain.Services
{
    public interface IRoverService
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetRoverByIdAsync(int id);
    }
}
