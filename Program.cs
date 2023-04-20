/*
Escriba un programa que calcule la velocidad (en m/s) de los corredores de la carrera de 1500
metros. La entrada consistirá en parejas de números (minutos, segundos) que dan el tiempo del
corredor; por cada corredor, el programa debe imprimir el tiempo en minutos y segundos, así como
la velocidad media. Ejemplo de entrada de datos: (3,53) (3,40) (3,46) (3,52) (4,0) (0,0); el último par
de datos se utilizará como fin de entrada de datos.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoVelocidad
{

  static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ingrese los tiempos de los corredores en minutos y segundos (0,0 para salir):");

      while (true)
      {
        Console.Write("Tiempo: ");
        string input = Console.ReadLine();

        if (input == "0,0") // Si se ingresa 0,0, se sale del ciclo while
        {
          break;
        }

        // Se convierte el tiempo ingresado en minutos y segundos
        string[] tiempo = input.Split(",");//se utiliza split() para separar la cadena de caracteres.
        int minutos = int.Parse(tiempo[0]);//la primer posicion (0) es la que almacena los minutos.
        int segundos = int.Parse(tiempo[1]);//la segunda posicion (1) es la que almacena los segundos.

        // Se calcula el tiempo total en segundos
        int tiempo_total = minutos * 60 + segundos;

        // Se calcula la velocidad en m/s
        double velocidad = 1500.0 / tiempo_total;

        // Se muestra el tiempo y la velocidad del corredor
        Console.WriteLine($"Tiempo: {minutos} minutos {segundos} segundos");
        Console.WriteLine($"Velocidad media: {velocidad} m/s\n");
      }
    }
  }
}