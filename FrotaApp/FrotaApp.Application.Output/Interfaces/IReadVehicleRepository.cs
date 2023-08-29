using FrotaApp.Application.Output.DTOS;

namespace FrotaApp.Application.Output.Interfaces
{
    public interface IReadVehicleRepository
    {
        IEnumerable<VechicleDTO> GetVechicles();
        VechicleDTO FindById(int id);
        IEnumerable<VechicleDTO> FindByCategoryId(int categoryId);
    }
}
