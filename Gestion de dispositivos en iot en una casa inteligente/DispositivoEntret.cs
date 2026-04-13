public abstract class DispositivoEntret : DispositivoBase
{
    private int _volumen;
    public int Volumen
    {
        get => _volumen;

        protected set
        {
            if (value >= 0 &&value <= 100)
            {
                _volumen = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "El volumen debe estar entre 0 y 100.");
            }
        }
    }
    public DispositivoEntret(int volumen, string nombreDisp, string id) : base(nombreDisp, id)
    {
        Volumen = volumen;
    }
    public virtual void SubirVolumen()
    {
        if (EstadoOF && Volumen < 100)
        {
            Volumen++;
            Console.WriteLine($"Se ha subido el volumen a :{Volumen}\n");
        }
        else if (!EstadoOF)
        {
            Console.WriteLine($"Debe encender [{Id}]-{NombreDisp} para realizar esta acción\n");
        }
    }
    public virtual void BajarVolumen()
    {
        if (EstadoOF && Volumen > 0)
        {
            Volumen--;
            Console.WriteLine($"Se ha bajado el volumen a :{Volumen} \n");
        }
        else if (!EstadoOF)
        {
            Console.WriteLine($"Debe encender [{Id}]-{NombreDisp} para realizar esta acción\n");
        }
    }
}