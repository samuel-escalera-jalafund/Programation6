namespace Progtamation6.Adapter;

public class RectangleAdapter : IRectangle
{
    private LegacyRectangle _legacyRectangle;

    public RectangleAdapter(LegacyRectangle legacyRectangle)
    {
        _legacyRectangle = legacyRectangle;
    }

    public override void Draw(int x, int y, int width, int height)
    {
        int x2 = x + width;
        int y2 = y + height;
        _legacyRectangle.Draw(x, y, x2, y2);
    }
    
    public static void Main()
    {
        //- Definicion: se utiliza para permitir que dos clases incompatibles trabajen juntas. La clase Adapter
        //implementa una interfaz esperada por el cliente y utiliza una instancia de una clase que no es
        //compatible para cumplir con las solicitudes.  
        // - Cuando usar: Cuando necesitas usar una clase existente pero su interfaz no coincide con la que necesitas.
        LegacyRectangle legacyRectangle = new LegacyRectangle();
        IRectangle rectangle = new RectangleAdapter(legacyRectangle);
        
        rectangle.Draw(10, 20, 30, 40);
    }
}