public abstract class DispositivoAcceso : DispositivoBase
{
    private bool _estadoAbCe;
    public bool EstadoAbCe { get => _estadoAbCe; protected set => _estadoAbCe = value; }

    public DispositivoAcceso(bool estadoAbCe, string nombreDisp, string id) : base(nombreDisp, id)
    {
        estadoAbCe = false;
    }
    public virtual void Abrir()
    {
        Console.WriteLine("Abriendo...\n");
        EstadoAbCe = true;
        Console.WriteLine($"Se abrió [{Id}]-{NombreDisp}\n");
    }
    public virtual void Cerrar()
    {
        Console.WriteLine("Cerrando...\n");
        EstadoAbCe = true;
        Console.WriteLine($"Se cerró [{Id}]-{NombreDisp}\n");
    }
}