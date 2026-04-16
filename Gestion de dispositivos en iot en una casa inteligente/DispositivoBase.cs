public abstract class DispositivoBase
{
    private string? _nombreDisp;
    private bool _estadoOF;
    private string? _id;
    private bool _modoEco;

    protected DispositivoBase(string? nombreDisp, string? id)
    {
        NombreDisp = nombreDisp;
        EstadoOF = false;
        Id = id;
        ModoEco = false;
    }
    public string NombreDisp
    {
        get => _nombreDisp;
        protected set
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Error crítico: Todo dispositivo debe tener un nombre.");
            }
            _nombreDisp = value.Trim();
        }
    }
    public string Id
    {
        get =>_id;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Error crítico: Todo dispositivo debe tener un ID único.");
            }
            _id = value.Trim();
        }
    }
    public bool EstadoOF { get => _estadoOF; protected set => _estadoOF = value; }
    public bool ModoEco { get => _modoEco; set => _modoEco = value; }

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