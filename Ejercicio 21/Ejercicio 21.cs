using System;

   class Ejercicio_21
   {
      static void Main(string[] args)
      {
      ArregloDigitos miArregloDigitos = new ArregloDigitos();
      Console.WriteLine("Ingrese un valor para obtener el número de cifras");
      
      int x = Convert.ToInt32(Console.ReadLine());
      int contador = miArregloDigitos.ObtenerCifras(x);
      
      Console.WriteLine("El número tiene {0} cifra/s\n", contador);
      
      int[] arreglo = miArregloDigitos.ObtenerResto(contador);
      int[] arregloInvertido= miArregloDigitos.InvertirArreglo(arreglo);

      Console.WriteLine("Arreglo generado con los valores del número ingresado:");
      for (int i=0;i<arregloInvertido.Length; i++)
      {
         Console.WriteLine("{0}",arregloInvertido[i]);
      }
      }
   }

