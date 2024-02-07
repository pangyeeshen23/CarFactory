using CarFactory.Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factory.Interface
{
    public interface ICarFactory
    {
        public ICar CreateCar();

        public ICar CreateSportCar();
    }
}
