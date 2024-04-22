using OtoServis.Data;
using OtoServis.Data.Concrete;
using OtoServis.Service.Abstract;

namespace OtoServis.Service.Concrete
{
    public class UserService : UserRepository, IUserService
    {
        public UserService(DatabaseContext context) : base(context)
        {
        }
    }
}
