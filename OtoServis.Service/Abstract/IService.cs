using OtoServis.Data.Abstract;
using OtoServis.Entities;

namespace OtoServis.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
