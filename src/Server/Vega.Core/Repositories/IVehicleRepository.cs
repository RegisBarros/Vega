using System.Threading.Tasks;
using Vega.Core.Models;

namespace Vega.Core.Repositories
{
    public interface IVehicleRepository
    {
         Task Create(Vehicle vehicle);
    }
}