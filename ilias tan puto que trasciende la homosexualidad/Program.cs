using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ilias_tan_puto_que_trasciende_la_homosexualidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = -123;
            Reverse(n);
        }

        public static int Reverse(int x)
        {
            Stack<char> numero = new Stack<char>();
            string numeros = x.ToString();
            int cantidad = numeros.Length;
            bool esNegativo = numeros[0] == '-';

            for (int i = (esNegativo ? 1 : 0); i < cantidad; i++)
            {
                numero.Push(numeros[i]); // Agrega cada dígito al stack
            }

            string numeroInvertido = (esNegativo ? "-" : "") + string.Concat(numero);

            int resultado = int.Parse(numeroInvertido);

            return resultado;
        }

    }
}

