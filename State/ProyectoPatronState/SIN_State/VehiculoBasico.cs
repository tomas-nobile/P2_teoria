using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIN_State
{
    public class VehiculoBasico
    {
        // Estados
        private const int APAGADO = 0;
        private const int PARADO = 1;
        private const int EN_MARCHA = 2;

        // Atributos
        private const int VELOCIDAD_MAXIMA = 200;
        private int estado = APAGADO;
        private int velocidadActual = 0;

        // Método Contacto (Encender vehiculo)
        public void Contacto()
        {
            // VER DIAGRAMA EstadosYTransiciones  
            switch (estado)
            {
                case APAGADO:
                    {
                        // El vehiculo arranca 
                        estado = PARADO;
                        velocidadActual = 0;
                        Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                        break;
                    }
                case PARADO:
                    {
                        // El vehiculo se apaga
                        estado = APAGADO;
                        Console.WriteLine("El vehiculo se encuentra ahora APAGADO");
                        break;
                    }
                case EN_MARCHA:
                    {
                        // No se puede detener el vehiculo en marcha!
                        Console.WriteLine("ERROR: No se puede cortar el contacto en marcha!");
                        break;
                    }
                default:
                    break;
            }
        }

        // Método Acelerar
        public void Acelerar()
        {
            switch (estado)
            {
                case APAGADO:
                    {
                        // Acelerar con el vehiculo apagado no sirve de mucho 
                        Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
                        break;
                    }
                case PARADO:
                    {
                        // El vehiculo se pone en marcha. Aumenta la velocidad y cambiamos de estado
                        velocidadActual += 10;
                        estado = EN_MARCHA;
                        Console.WriteLine("El vehiculo se encuentra ahora EN_MARCHA");
                        Console.WriteLine("Velocidad actual: " + velocidadActual);
                        break;
                    }
                case EN_MARCHA:
                    {
                        // Aumentamos la velocidad, permaneciendo en el mismo estado
                        if (velocidadActual >= VELOCIDAD_MAXIMA)
                            Console.WriteLine("ERROR: El coche ha alcanzado su velocidad maxima");
                        else
                            velocidadActual += 10;
                        break;
                    }
                default:
                    break;
            }
        }

        // Método Frenar
        public void Frenar()
        {
            switch (estado)
            {
                case APAGADO:
                    {
                        // Frenar con el vehiculo parado tampoco sirve de mucho...
                        Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
                        break;
                    }
                case PARADO:
                    {
                        // No ocurre nada. Si el vehiculo ya se encuentra detenido, no habra efecto alguno
                        Console.WriteLine("ERROR: El vehiculo ya se encuentra detenido");
                        break;
                    }
                case EN_MARCHA:
                    {
                        // Reducimos la velocidad. Si esta llega a 0, cambiaremos a estado "PARADO"
                        velocidadActual -= 10;
                        if (velocidadActual <= 0)
                        {
                            estado = PARADO;
                            Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                        }
                        Console.WriteLine("Velocidad actual: " + velocidadActual);
                        break;
                    }
                default:
                    break;
            }
        }


    }
}
