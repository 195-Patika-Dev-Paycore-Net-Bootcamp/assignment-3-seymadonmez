using System.Linq;
using WasteCollectionManagement.Models;

namespace WasteCollectionManagement.Context
{
    public interface IMapperSession
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void CloseTransaction();
        void Save(Vehicle entity);
        void Update(Vehicle entity);
        void Delete(Vehicle entity);

        IQueryable<Vehicle> Vehicles { get; }
    }
}
