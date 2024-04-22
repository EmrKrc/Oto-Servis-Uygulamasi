using OtoServis.Data;
using OtoServis.Data.Concrete;
using OtoServis.Entities;
using OtoServis.Service.Abstract;

namespace OtoServis.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
