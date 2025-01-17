using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
namespace ApplicationCore.Interfaces
{
    public interface IPlaneRepository : IRepository<Plane>
    {
        Task<IEnumerable<Plane>> getPlanebyMakerId(string maker_id);
    }
}