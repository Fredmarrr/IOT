 public class Radio : DispositivoEntret
{
    private decimal _frecuenciaActual;
    public decimal FrecuenciaActual
    {
        get => _frecuenciaActual;
        private set
        {
            if (value > 0 && value <= 300)//300 es el limite de la frecuencia para nuestra radio al menos para la radio que estamos utilizando de prueba
            {
                _frecuenciaActual = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Dato invalido");
            }
        }
    }
    public Radio(int volumen, string nombreDisp, string id, decimal frecuenciaActual) : base(volumen, nombreDisp, id)
    {
        FrecuenciaActual = frecuenciaActual;
    }
    /// <summary>
    /// Cambia la frecuencia de Radio junto a su validacion
    /// </summary>
    public void CambiarFrecuencia()
    {
        decimal nuevaFrecuencia;
        Console.WriteLine("Cambiando canal por:\n");
        nuevaFrecuencia = decimal.Parse(Console.ReadLine());
        FrecuenciaActual = nuevaFrecuencia;
        Console.WriteLine($"Canal actual: {FrecuenciaActual}\n");
    }
    /// <summary>
    /// Utiliza otro metodo paraa el modo ecologico
    /// </summary>
    public override void ModoEcologico()
    {
        Console.WriteLine($"Modo ecologico activado para [{Id}]-{NombreDisp} \n");
    }
}