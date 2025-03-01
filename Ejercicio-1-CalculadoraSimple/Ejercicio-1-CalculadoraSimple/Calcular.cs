using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_CalculadoraSimple
{
    internal class Calcular
    {
        public static void OperarNumeros(int num1, int num2, char operacion) 
        {
            switch (operacion)
            {
                case '+': Console.WriteLine(num1 + num2); break;
                case '-': Console.WriteLine(num1 - num2); break;
                case '*': Console.WriteLine(num1 * num2); break;
                case '/': Console.WriteLine((double)num1 / num2); break;
                default: Console.WriteLine("Operador invalido"); break;

            }
        }
    }
}
