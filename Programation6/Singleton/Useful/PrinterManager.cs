namespace Progtamation6.Singleton;

public class PrinterManager
{
    private static PrinterManager _instance;
    private static readonly object _lock = new object();
    
    private PrinterManager() 
    {
        Console.WriteLine("Impresora conectada");
    }

    public static PrinterManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new PrinterManager();
                }
                return _instance;
            }
        }
    }

    public void Print(string document)
    {
        Console.WriteLine($"Imprimiendo: {document}");
    }

    /// <summary>
    /// útil aquí porque asegura que todas las solicitudes de impresión pasen por una única instancia
    /// del PrinterManager, evitando conflictos en el acceso a la impresora
    /// </summary>
    public static void Main()
    {
        PrinterManager.Instance.Print("Dibujo");
        PrinterManager.Instance.Print("Documento");
    }
}
