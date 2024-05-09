using Microsoft.EntityFrameworkCore;

namespace VehicleRegistrationBE.Entities.DataContext
{
    public class TransactionDBDataContext : DbContext
    {
        public TransactionDBDataContext(DbContextOptions<TransactionDBDataContext> options) : base(options)
        {
        }

        public virtual DbSet<TrBPKB> TransactionBPKBEntities { get; set; }
    }
}
