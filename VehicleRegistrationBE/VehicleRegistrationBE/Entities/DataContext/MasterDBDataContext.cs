using Microsoft.EntityFrameworkCore;

namespace VehicleRegistrationBE.Entities.DataContext
{
    public class MasterDBDataContext : DbContext
    {
        public MasterDBDataContext(DbContextOptions<MasterDBDataContext> options) : base(options)
        {
        }

        public virtual DbSet<MsUserEntity> MasterUserEntities { get; set; }
        public virtual DbSet<MsStorageLocationEntity> MasterStorageLocationEntities { get; set; }
    }
}
