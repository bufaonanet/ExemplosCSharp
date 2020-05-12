using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulo
{
     class Calculadora
    {
        public static int Soma(params int[] numeros)
        {
            int sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }

            return sum;
        }

        public static void Triplicar(int origem, out int resultado)
        {
            resultado = origem * 3;
        }

    }
}
