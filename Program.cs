using CarFactory.Class;
using CarFactory.Factory;
using CarFactory.Factory.Interface;



var client = new Client();
client.CreateCar(new SedanFactory());
client.CreateCar(new SUVFactory());
client.CreateSportCar(new SUVFactory());

public class Client
{

    public void CreateCar(ICarFactory factory)
    {
        var car = factory.CreateCar();
        Console.WriteLine(car.Name);
    }

    public void CreateSportCar(ICarFactory factory)
    {
        var sportCar = factory.CreateSportCar();
        Console.WriteLine(sportCar.Name);
    }
}
