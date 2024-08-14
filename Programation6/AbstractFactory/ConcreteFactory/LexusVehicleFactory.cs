using Programation6.AbstractFactory.AbstractFactory;
using Programation6.AbstractFactory.AbstractProdcuts;
using Programation6.AbstractFactory.ConcreateProducts;

namespace Programation6.AbstractFactory.ConcreteFactory;

public class LexusVehicleFactory : IVehicleFactory
{
    public ICar CreatCar()
    {
        return new Sedan();
    }

    public IMotorcycle CreatMotorcycle()
    {
        return new Ninja();
    }
}