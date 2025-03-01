using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_VerificarPalindromo
{
    internal class Palindromo
    {
        public static void VerificarPalindromo(string palabra) // se crea este metodo sin retorno pero que recibe un parametro
        { 
            string pa = ""; // se declara esta variable del tipo string para poder almacenar cada caracter de la palabra
            int longitud = palabra.Length; // contamos la cantidad de caracteres tiene la palabra ya que nos servira como rango en la condicion del ciclo for
            for (int i = longitud - 1; i >= 0; i--)  // configuramos el for para que recorra la palabra pero de derecha a izquierda osea de atras hacia adelante
            {
                pa = pa + palabra[i]; // se usa la variable string como acumulador para que con el simbolo + se vaya concatenando cada caracter por cada vuelta del ciclo for
            }
            Console.WriteLine($"La palabra al reves se escribe asi {pa}"); // imprimimos el acumulador final para ver como seria escrita al revez la palabra
            if (pa == palabra) // se usa una condicional para veirificar que la palabra ingresada por el usuario y que se almacena en la variable palabra que es un parametro de este metodo
                // sea igual al acumulador
            {
                Console.WriteLine("La palabra es un palindromo"); // si son iguales se manda un mensaje que la palabra es palindroma
            }
            else
            {
                Console.WriteLine("La palabra no es un palindromo"); // si en caso no son iguales pues se dice que no son palindromas
            }
        }
    }
}
