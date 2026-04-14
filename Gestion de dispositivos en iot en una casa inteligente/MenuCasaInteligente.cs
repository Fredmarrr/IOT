public class MenuCasaInteligente
{
    List<DispositivoBase> _dispositivos;
    public MenuCasaInteligente(List<DispositivoBase> dispositivos)
    {
        _dispositivos = dispositivos;
    }
    public void Menu()
    {
        bool salir = false;
        int num;
        Console.Clear();
        Console.WriteLine("=== PANEL CENTRAL DE LA CASA INTELIGENTE ===");

        // Imprimimos todos los dispositivos disponibles
        for (int i = 0; i < _dispositivos.Count; i++)
        {
            var disp = _dispositivos[i];
            string estado = disp.EstadoOF ? "ON" : "OFF";
            Console.WriteLine($"{i + 1}. {disp.NombreDisp} [{estado}]");
        }
        Console.Write("\nElige el número del dispositivo a controlar: ");
        Console.WriteLine("0. Salir del sistema");
        do
        {
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    salir = true;
                    continue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Dato invalido");
                num = -1;
            }
        } while (num == -1);
        if(num>0&&num<_dispositivos.Count)
        {
            DispositivoBase dispositivo = _dispositivos[num-1];
            MenuCasa(dispositivo);
        }

    }
 
    private void MenuCasa(DispositivoBase dispositivo)
    {
        Console.WriteLine($"\n--- Controlando: {dispositivo.NombreDisp} ---");
        Console.WriteLine("1. Encender / Apagar");
        Console.WriteLine("2. Activar Modo Ecológico");
        if(dispositivo is Televisor tele)
        {
            Console.WriteLine("3. Subir/Bajar volumen");
            Console.WriteLine("4. Cambiar de canales");
        }
        else if (dispositivo is Radio rad)
        {
            Console.WriteLine("3. Subir/Bajar volumen");
            Console.WriteLine("4. Cambiar de frecuencia");
        }
        else if(dispositivo is AireAcondicionado aire)
        {
            Console.WriteLine("3. Subir/Bajar temperatura");
            Console.WriteLine("4. Cambiar velocidad");
        }
        else if(dispositivo is PuertaInteligente puerta)
        {
            Console.WriteLine("3. Abrir/Cerrar ");
            Console.WriteLine("4. Poner/Quitar seguro");
        }
        else if(dispositivo is PortonGaraje porton)
        {
            Console.WriteLine("3. Abrir/Cerrar ");
        }    
    }
   
}﻿
