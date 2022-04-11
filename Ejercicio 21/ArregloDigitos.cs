using System;

class ArregloDigitos
{
   private int x;

   public int ObtenerCifras(int x)
   {
      this.x = x;
      int contador = 0;

      while (x % 10 != 0 || (x % 10 == 0 && x > 0))
      {
         x = x / 10;
         contador++;
      }
      return contador;
   }

   public int[] ObtenerResto(int contador)
   {
      int resto;
      int[] arreglo = new int[contador];

      for (int i = 0; i < arreglo.Length; i++)
      {
         resto = x % 10;
         this.x = x / 10;
         arreglo[i] = resto;
      }
      return arreglo;
   }

   public int[] InvertirArreglo(int[] arreglo)
   {
      int[] array = new int[arreglo.Length];

      for (int i = 0; i < arreglo.Length; i++)
      {
         array[i] = arreglo[arreglo.Length - 1-i];
      }
      return array;
   }
}