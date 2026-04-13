public abstract class DispositivoBase
{
    private string? _nombreDisp;
    private bool _estadoOF;
    private string? _id;

    protected DispositivoBase(string? nombreDisp, string? id)
    {
        NombreDisp = nombreDisp;
        EstadoOF = false;
        Id = id;
    }

    public string? NombreDisp { get => _nombreDisp; protected set => _nombreDisp = value; }
    public string? Id { get => _id; protected set => _id = value; }
    public bool EstadoOF { get => _estadoOF; protected set => _estadoOF = value; }

    public virtual void Encender()
    {
        Console.WriteLine($"Encendiendo dispositivo [{Id}]-{NombreDisp}...\n");
        EstadoOF = true;
        Console.WriteLine($"[{Id}]-{NombreDisp} encendido\n");
        Console.WriteLine(EstadoOF ? "Disponibilidad: disponible" : "Disponibilidad: no disponible");
      
    }
    public virtual void Apagar()
    {
        Console.WriteLine($"Apagando dispositivo [{Id}]-{NombreDisp}...\n");
        EstadoOF = false;
        Console.WriteLine($"[{Id}]-{NombreDisp} se apagó\n");
    }
    public virtual void ModoEcologico()
    { }
}