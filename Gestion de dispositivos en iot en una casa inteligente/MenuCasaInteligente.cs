
public class MenuCasaInteligente
{
    private List<DispositivoBase> _dispositivos;

    public MenuCasaInteligente(List<DispositivoBase> dispositivos)
    {
        _dispositivos = dispositivos;
    }
    /// <summary>
    /// Imprime la lista de los objetos y luego de seleccionar imprime el menu interactivo o sale del menu
    /// </summary>
    /// <param name="dispositivo"></param>
    public void Menu()
    {
        bool salir = false;
        int num;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== PANEL CENTRAL DE LA CASA INTELIGENTE ===");

            // Imprimimos todos los dispositivos disponibles
            for (int i = 0; i < _dispositivos.Count; i++)
            {
                var disp = _dispositivos[i];
                string estado = disp.EstadoOF ? "ON" : "OFF";
                Console.WriteLine($"{i + 1}. {disp.NombreDisp} [{estado}]");
            }

            Console.WriteLine("0. Salir del sistema");
            Console.Write("\nElige el número del dispositivo a controlar: ");

            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num == 0)
                    {
                        Console.WriteLine("Apagando el sistema...");
                        Environment.Exit(0);
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato inválido. Por favor ingresa un número.");
                    num = -1;
                }
            } while (num == -1);

            if (num > 0 && num <= _dispositivos.Count)
            {
                DispositivoBase dispositivo = _dispositivos[num - 1];
                MenuCasa(dispositivo);
            }
            else
            {
                Console.WriteLine("Ese dispositivo no existe. Presiona ENTER para intentar de nuevo.");
                Console.ReadLine();
            }
        }
    }

    private void MenuCasa(DispositivoBase dispositivo)
    {
        string opc;
        Console.Clear();
        Console.WriteLine($"\n--- Controlando: {dispositivo.NombreDisp} ---");
        Console.WriteLine("1. Encender / Apagar");
        Console.WriteLine("2. Activar/Desactivar Modo Ecológico");

        if (dispositivo is Televisor tele)
        {
            Console.WriteLine("3. Subir/Bajar volumen");
            Console.WriteLine("4. Cambiar de canales");
        }
        else if (dispositivo is Radio rad)
        {
            Console.WriteLine("3. Subir/Bajar volumen");
            Console.WriteLine("4. Cambiar de frecuencia");
        }
        else if (dispositivo is AireAcondicionado aire)
        {
            Console.WriteLine("3. Subir/Bajar temperatura");
            Console.WriteLine("4. Cambiar velocidad");
        }
        else if (dispositivo is PuertaInteligente puerta)
        {
            Console.WriteLine("3. Abrir/Cerrar ");
            Console.WriteLine("4. Poner/Quitar seguro");
        }
        else if (dispositivo is PortonGaraje porton)
        {
            Console.WriteLine("3. Abrir/Cerrar ");
        }

        Console.Write("\nElige la acción a ejecutar (o presiona ENTER para volver): ");
        string accion = Console.ReadLine();

        switch (accion)
        {
            case "1":
                if (dispositivo.EstadoOF)
                {
                    dispositivo.Apagar();
                }
                else
                {
                    dispositivo.Encender();
                }
                break;

            case "2":
                dispositivo.ModoEcologico();
                break;

            case "3":
                if (dispositivo is Televisor t)
                {
                    Console.WriteLine("1. Subir volumen\n2. Bajar volumen");
                    opc = Console.ReadLine();
                    if (opc == "1") t.SubirVolumen();
                    else if (opc == "2") t.BajarVolumen();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                else if (dispositivo is Radio r)
                {
                    Console.WriteLine("1. Subir volumen\n2. Bajar volumen");
                    opc = Console.ReadLine();
                    if (opc == "1") r.SubirVolumen();
                    else if (opc == "2") r.BajarVolumen();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                else if (dispositivo is AireAcondicionado a)
                {
                    Console.WriteLine("1. Subir temperatura\n2. Bajar temperatura");
                    opc = Console.ReadLine();
                    if (opc == "1") a.SubirTemp();
                    else if (opc == "2") a.BajarTemp();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                else if (dispositivo is PuertaInteligente p)
                {
                    Console.WriteLine("1. Abrir puerta\n2. Cerrar puerta");
                    opc = Console.ReadLine();
                    if (opc == "1") p.Abrir();
                    else if (opc == "2") p.Cerrar();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                else if (dispositivo is PortonGaraje port)
                {
                    Console.WriteLine("1. Abrir portón\n2. Cerrar portón");
                    opc = Console.ReadLine();
                    if (opc == "1") port.Abrir();
                    else if (opc == "2") port.Cerrar();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                break;

            case "4":
                if (dispositivo is Televisor t2)
                {
                    t2.CambiarCanales();
                }
                else if (dispositivo is Radio r2)
                {
                    r2.CambiarFrecuencia();
                }
                else if (dispositivo is AireAcondicionado a2)
                {
                    a2.CambiarVelocidad();
                }
                else if (dispositivo is PuertaInteligente p2)
                {
                    Console.WriteLine("1. Poner seguro\n2. Quitar seguro");
                    opc = Console.ReadLine();
                    if (opc == "1") p2.PonerSeguro();
                    else if (opc == "2") p2.QuitarSeguro();
                    else Console.WriteLine("Dato inválido. No se realizó ninguna acción.");
                }
                break;

            case "":
                break;

            default:
                Console.WriteLine("\nOpción no válida.");
                break;
        }

        Console.WriteLine("\nAcción terminada. Presiona cualquier tecla para volver al menú principal.");
        Console.ReadLine();
    }
}
