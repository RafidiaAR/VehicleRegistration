using Microsoft.EntityFrameworkCore;

namespace VehicleRegistrationBE.Entities
{
    public class TransactionDBDataContext : DbContext
    {
        public TransactionDBDataContext(DbContextOptions<TransactionDBDataContext> options) : base(options)
        {
        }
    }
}
