using Programation6.AbstractFactory.AbstractProdcuts;

namespace Programation6.AbstractFactory.AbstractFactory;

public interface IVehicleFactory
{
    ICar CreatCar();
    IMotorcycle CreatMotorcycle();
}