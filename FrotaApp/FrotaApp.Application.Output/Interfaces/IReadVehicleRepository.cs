using FrotaApp.Application.Output.DTOS;

namespace FrotaApp.Application.Output.Interfaces
{
    public interface IReadVehicleRepository
    {
        IEnumerable<VehicleDTO> GetVehicles();
        VehicleDTO FindById(int id);
        IEnumerable<VehicleDTO> FindByCategoryId(int categoryId);
    }
}
