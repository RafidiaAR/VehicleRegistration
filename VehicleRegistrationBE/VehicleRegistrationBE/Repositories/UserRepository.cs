using VehicleRegistrationBE.Entities.DataContext;
using VehicleRegistrationBE.Entities;

namespace VehicleRegistrationBE.Repositories
{
    public class UserRepository
    {
        protected readonly MasterDBDataContext _masterDBDataContext;

        public UserRepository(MasterDBDataContext masterDBDataContext)
        {
            _masterDBDataContext = masterDBDataContext;
        }

        public MsUserEntity FindByUsernameAndPassword(string username, string password)
        {
            var data = _masterDBDataContext
                .MasterUserEntities
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();

            return data;
        }
    }
}
