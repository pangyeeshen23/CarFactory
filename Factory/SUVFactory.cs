using CarFactory.Class;
using CarFactory.Class.Interface;
using CarFactory.Factory.Interface;

namespace CarFactory.Factory
{
    public class SUVFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new SUV();
        }

        public ICar CreateSportCar()
        {
            throw new NotImplementedException();
        }
    }
}
