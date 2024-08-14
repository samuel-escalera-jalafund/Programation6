using Programation6.AbstractFactory.AbstractProdcuts;

namespace Programation6.AbstractFactory.ConcreateProducts;

public class Ninja : IMotorcycle
{
    public void Ride()
    {
        Console.WriteLine("Driving a Ninja Motorcycle");
    }
}