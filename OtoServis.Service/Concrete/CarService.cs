using OtoServis.Data;
using OtoServis.Data.Concrete;
using OtoServis.Service.Abstract;

namespace OtoServis.Service.Concrete
{
    public class CarService : CarRepository, ICarService
    {
        public CarService(DatabaseContext context) : base(context)
        {
        }
    }
}
