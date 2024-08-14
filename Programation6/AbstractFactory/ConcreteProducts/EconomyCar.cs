using Programation6.AbstractFactory.AbstractProdcuts;

namespace Programation6.AbstractFactory.ConcreateProducts;

public class EconomyCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a economy car");
    }
}   