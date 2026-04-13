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
        int nuevoCanal;
        Console.WriteLine("Cambiando canal por:\n");
        nuevoCanal = int.Parse(Console.ReadLine());
        CanalActual = nuevoCanal;
        Console.WriteLine($"Canal actual: {CanalActual}\n");
    }
    public override void ModoEcologico()
    {
        Console.WriteLine($"Modo ecologico activado para [{Id}]-{NombreDisp} se bajó el brillo del dispositivo\n");
    }
}