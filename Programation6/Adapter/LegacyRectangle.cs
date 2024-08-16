namespace Progtamation6.Adapter;

public class LegacyRectangle
{
    public void Draw(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine($"Rectangle drawn from ({x1},{y1}) to ({x2},{y2})");
    }
}