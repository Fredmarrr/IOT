public class PuertaInteligente:DispositivoAcceso
{
    private bool _seguro;

    public bool Seguro { get => _seguro; private set => _seguro = value; }
    public PuertaInteligente(bool seguro, bool estadoAbCe, string nombreDisp, string id):base(estadoAbCe, nombreDisp, id)
    {
        seguro = false;
    }
    /// <summary>
    /// Activa y pone el seguro a puerta inteligente
    /// </summary>
    public void PonerSeguro()
    {
        Console.WriteLine($"Poniendo seguro a [{Id}]-{NombreDisp}");
        Seguro = true;
        Console.WriteLine($"Seguro puesto para [{Id}]-{NombreDisp}\n");
    }
    /// <summary>
    /// Cierra y quita el seguro a puerta inteligente
    /// </summary>
    public void QuitarSeguro()
    {
        Console.WriteLine($"Quitando seguro a [{Id}]-{NombreDisp}");
        Seguro = false; 
        Console.WriteLine($"Seguro quitado para [{Id}]-{NombreDisp}\n");
    }

}