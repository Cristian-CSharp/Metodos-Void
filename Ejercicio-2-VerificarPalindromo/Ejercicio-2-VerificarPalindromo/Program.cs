using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_VerificarPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra; // se declaran la variable para almacenar el valor ingresado por el usuario
            bool esPalabra; // se declara esta variable para poder usarla como ayuda para salir del bucle en caso la palabra ingresada sea valida

            do // usamo el do-while como ciclo principal para que evalua la palabra 
            {
                esPalabra = true; // en un principio toda palabra ingresaba sera verdadera

                Console.Write("Ingrese una palabra: "); // se manda a ingresar un palabra
                palabra = Console.ReadLine();  // en la variable palabra se almacena el valor que el usuario ingrese por consola

                int longitud = palabra.Length; // contamos la cantidad de caracteres tiene la palabra ya que nos servira como rango en la condicion del ciclo for

                for (int i = 0; i < longitud; i++) // usamos el ciclo for para recorrer el valor ingresado, caracter por caracter
                {    
                    if (!(palabra[i] >= 'A' && palabra[i] <= 'Z') && !(palabra[i] >= 'a' && palabra[i] <= 'z') && palabra[i] != 'á' && palabra[i] != 'é' && palabra[i] != 'í' && palabra[i] != 'ó' && palabra[i] != 'ú' && palabra[i] != 'ñ' && palabra[i] != ' ') // verificamos que el caracter no sea una letra
                    {
                        Console.WriteLine("Error, debe ingresar solamente palabras"); // si es un numero o simbolo se ingresa al if y se manda el mensaje de error
                        esPalabra = false; // el valor del booleano cambia, para usarlo luego en la condicion del While
                        break; // al encontrarse con un numero o simbolo automaticamente con un break salimos del for y pasamos a evaluar la condicion del while
                    }
                } 
            }
            while (!esPalabra); // como el valor del booleano cambio a false, ahora la negacion de false es true lo que significa que seguiremos en el bucle
            // hasta que se ingrese una palabra valida y el valor del booleano no cambie y se mantenga en true al negarlo sea false y eso significara que porfin
            // podremos salir del bucle

            Palindromo.VerificarPalindromo(palabra); // al salir del bucle con una palabra valida se llama al metodo para verificar si la palabra es palindroma o no
            // mandando como parametros la palabra ingresada por el usuario previamente validada
        }
    }
}
