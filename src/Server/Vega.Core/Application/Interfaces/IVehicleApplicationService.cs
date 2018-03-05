using System.Threading.Tasks;
using Vega.Core.Dtos;

namespace Vega.Core.Application.Interfaces
{
    public interface IVehicleApplicationService
    {
         Task Create(VehicleDto vehicle);
    }
}