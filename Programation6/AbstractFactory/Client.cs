using Programation6.AbstractFactory.AbstractFactory;
using Programation6.AbstractFactory.AbstractProdcuts;
using Programation6.AbstractFactory.ConcreteFactory;

namespace Programation6.AbstractFactory;

public class Client
{
    private readonly ICar _car;
    private readonly IMotorcycle _motorcycle;

    public Client(IVehicleFactory vehicleFactory)
    {
        _car = vehicleFactory.CreatCar();
        _motorcycle = vehicleFactory.CreatMotorcycle();
    }

    public void Run()
    {
        _car.Drive();
        _motorcycle.Ride();
    }

    public static void Main()
    {
        IVehicleFactory lexusFactory = new LexusVehicleFactory();
        var client1 = new Client(lexusFactory);
        client1.Run();

        IVehicleFactory economyFactory = new EconomyCarFactory();
        var client2 = new Client(economyFactory);
        client2.Run();
        
        // - IVehicle: interfaz que define metodos para crear autos y motocicletas
        // - LexusVehicleFactory y EconomyVehicleFactory son implementaciones concretas de la fabrica,
        // que crean vehículos concretos.
        // - ICar y IMotorcycle son los productos abstractos que representan vehículos.
        // - Sedan, SportsBike, etc: son implementaciones concretas de los productos.
        // En el main, el cliente1 usa la fabrica lexusFactory
        // y client2 usa la economyFacptry y  cada fabrica crea sus vehiculos especificos
    }
}