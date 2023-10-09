﻿﻿//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    double suma = 0;

    //llamadas a las clases
    List<Figura> figuras = new List<Figura>();
    Rectangulo r1 = new Rectangulo(3.9, 3);
    figuras.Add(r1);
    Rectangulo r2 = new Rectangulo(5.2, 2);
    figuras.Add(r2);
    Circulo c1 = new Circulo(4);
    figuras.Add(c1);
    Circulo c2 = new Circulo(2);
    figuras.Add(c2);
    TrianguloEquilatero t1 = new TrianguloEquilatero(3);
    figuras.Add(t1);
    t1 = new TrianguloEquilatero(5);
    figuras.Add(t1);



    //bucle para recorrar la lista
    foreach (Figura figura in figuras)
    {
      Console.WriteLine(figura.ToString());
      Console.WriteLine();
      suma += figura.GetArea();

    }
    Console.WriteLine($"La suma total del area es: {suma}");


  }

}