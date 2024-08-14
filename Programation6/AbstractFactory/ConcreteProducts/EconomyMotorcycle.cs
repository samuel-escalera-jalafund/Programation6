using Programation6.AbstractFactory.AbstractProdcuts;

namespace Programation6.AbstractFactory.ConcreateProducts;

public class EconomyMotorcycle : IMotorcycle
{
    public void Ride()
    {
        Console.WriteLine("Rider a economy motorcyle");
    }
}