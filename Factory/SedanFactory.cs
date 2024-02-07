using CarFactory.Class;
using CarFactory.Class.Interface;
using CarFactory.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factory
{
    public class SedanFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Sedan();
        }

        public ICar CreateSportCar()
        {
            return new SportSedan();
        }
    }
}
