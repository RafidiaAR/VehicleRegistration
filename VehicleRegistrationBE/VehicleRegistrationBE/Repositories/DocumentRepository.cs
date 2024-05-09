using Microsoft.EntityFrameworkCore;
using VehicleRegistrationBE.Entities;
using VehicleRegistrationBE.Entities.DataContext;

namespace VehicleRegistrationBE.Repositories
{
    public class DocumentRepository
    {
        protected readonly TransactionDBDataContext _transactionDBDataContext;

        public DocumentRepository(TransactionDBDataContext transactionDBDataContext)
        {
            _transactionDBDataContext = transactionDBDataContext;
        }

        public void Create(TrBPKB entity)
        {
            _transactionDBDataContext.TransactionBPKBEntities.Add(entity);
            _transactionDBDataContext.SaveChanges();
        }
    }
}
