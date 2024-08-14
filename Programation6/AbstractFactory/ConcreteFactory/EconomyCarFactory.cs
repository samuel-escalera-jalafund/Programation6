using Programation6.AbstractFactory.AbstractFactory;
using Programation6.AbstractFactory.AbstractProdcuts;
using Programation6.AbstractFactory.ConcreateProducts;

namespace Programation6.AbstractFactory.ConcreteFactory;

public class EconomyCarFactory : IVehicleFactory
{
    public ICar CreatCar()
    {
        return new EconomyCar();
    }

    public IMotorcycle CreatMotorcycle()
    {
        return new EconomyMotorcycle();
    }
}