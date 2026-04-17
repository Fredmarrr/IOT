public abstract class DispositivoClima : DispositivoBase
{
    private int? _temperatura;
    public int? Temperatura

    {
        
        get => _temperatura;

        protected set
        {
            if (value <= 33 && value >= 14)
            {
                _temperatura = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), " Excede los valores de temperatura");
            }
        }
    }
    public DispositivoClima(int temperatura, string nombreDisp, string id) : base(nombreDisp, id)
    {
        Temperatura = temperatura;
    }
    /// <summary>
    /// Sube la temperatura con una validacion
    /// </summary>
    public virtual void SubirTemp()
    {
        if (EstadoOF && Temperatura > 14)
        {
            Temperatura++;
            Console.WriteLine($"Se ha subido la temperatura a {Temperatura}\n");
        }
        else if (!EstadoOF)
            Console.WriteLine($"Debe encender [{Id}]-{NombreDisp} para realizar esta acción\n");
    }
    /// <summary>
    /// Baja la temperatura con una validacion
    /// </summary>
    public virtual void BajarTemp()
    {
        if (EstadoOF && Temperatura < 33)
        {
            Temperatura--;
            Console.WriteLine($"Se ha bajado la temperatura a {Temperatura}\n");
        }
        else if (!EstadoOF)
            Console.WriteLine($"Debe encender [{Id}]-{NombreDisp} para realizar esta acción\n");
    }

}