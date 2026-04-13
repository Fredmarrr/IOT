public class AireAcondicionado : DispositivoClima
{
    private int _velocidad;

    public int Velocidad
    {
        get => _velocidad;
        private set
        {
            if (value <= 3 && value > 0)
                _velocidad = value;
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "El volumen debe estar entre 0 y 100.");
            }
        }
        
    }
    public AireAcondicionado(int velocidad, string nombreDisp, string id,int temperatura):base(temperatura,nombreDisp,id)
    {
        Velocidad=velocidad;
    }
    public void CambiarVelocidad()
    {
        int velocidadNueva;
        Console.WriteLine("Cambiando velocidad por: \n");
        velocidadNueva = int.Parse(Console.ReadLine());
        if (velocidadNueva <= 3 && velocidadNueva > 0)
        {
            Velocidad = velocidadNueva;
            Console.WriteLine($"Velocidad: {Velocidad}\n");
        }

        
    }
}