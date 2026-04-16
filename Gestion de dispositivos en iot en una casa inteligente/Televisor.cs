public class Televisor : DispositivoEntret
{
    private int _canalActual;
    public int CanalActual
    {
        get => _canalActual;
        private set
        {
            if (value > 0 && value <= 200)//200 es el limite de canales al menos para el televisor que estamos utilizando de prueba
            {
                _canalActual = value;

            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Dato invalido");
            }
        }
    }
    public Televisor(int volumen, string nombreDisp, string id, int canalActual) : base(volumen, nombreDisp, id)
    {
        CanalActual = canalActual;
    }

    public void CambiarCanales()
    {
        Console.WriteLine("Cambiando canal por:\n");
        try
        {
            int nuevoCanal = int.Parse(Console.ReadLine());
            CanalActual = nuevoCanal;
            Console.WriteLine($"Canal actual: {CanalActual}\n");
        }
        catch (FormatException)
        {
            Console.WriteLine("Dato inválido. Debes ingresar un número.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public override void ModoEcologico()
    {
        if(!ModoEco)
        {
            Console.WriteLine($"Modo ecologico activado para [{Id}]-{NombreDisp} se bajó el brillo del dispositivo\n");
            ModoEco = true;
        }
        else if(ModoEco)
        {
            Console.WriteLine($"Modo ecologico desactivado para [{Id}]-{NombreDisp}\n");
            ModoEco = false;
        }
        
    }
}