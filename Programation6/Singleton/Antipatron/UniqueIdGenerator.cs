namespace Progtamation6.Singleton.Antipatron;

public class UniqueIdGenerator
{
    private static UniqueIdGenerator _instance;
    private static readonly object _lock = new object();
    private int _currentId;

    private UniqueIdGenerator() 
    {
        _currentId = 0;
    }

    public static UniqueIdGenerator Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new UniqueIdGenerator();
                }
                return _instance;
            }
        }
    }

    public int GetNextId()
    {
        return ++_currentId;
    }
    /// <summary>
    /// En caso de usar multiples hilos, podriamos tener un problema de sincronizacion
    /// si es que varios prcesoso quieren acceder a la instancia a la vez
    /// </summary>
    public static void Main()
    {
        var id1 = UniqueIdGenerator.Instance.GetNextId();
        var id2 = UniqueIdGenerator.Instance.GetNextId();

        Console.WriteLine($"ID 1: {id1}");
        Console.WriteLine($"ID 2: {id2}");
    }
}
