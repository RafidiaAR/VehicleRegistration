using Microsoft.EntityFrameworkCore;
using VehicleRegistrationBE.Entities;
using VehicleRegistrationBE.Entities.DataContext;

namespace VehicleRegistrationBE.Repositories
{
    public class StorageLocationRepository
    {
        protected readonly MasterDBDataContext _masterDBDataContext;

        public StorageLocationRepository(MasterDBDataContext masterDBDataContext) 
        {
            _masterDBDataContext = masterDBDataContext;
        }

        public List<MsStorageLocationEntity> GetAll()
        {
            return _masterDBDataContext
                .MasterStorageLocationEntities
                .ToList();
        }
    }
}
