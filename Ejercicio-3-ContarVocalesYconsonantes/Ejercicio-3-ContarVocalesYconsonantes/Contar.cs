using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ContarVocalesYconsonantes
{
    internal class Contar
    {
        public static void ContarLetras(string texto) // se crea un metod para validar la cantidad de vocales y consonantes en el texto ingresado
        {
            int contadorVocales = 0, contadorConsonantes = 0; // se declaran dos variables como contadores de vocales y consonanates iniciandolos en cero
            int longitud = texto.Length; // se mide la cantidad de caracteres que tiene el texto incluyendo vocales, consonantes, espacios, simbolos y numeros osea cuenta la cantidad total de caracteres
            
            for (int i = 0; i < longitud; i++) // se usa un for para recorrer el texto caracter por caracter 
            {
                if (char.IsLetter(texto[i])) // se evalua si el caracter es una letra (vocales y consonantes) si es asi ingresa al if sino se pasa al siguiente caracter
                {
                    if ("aeiouáéíóú".Contains(texto[i])) // uso el metodo .Contains() para validar si la letra ingresada esta en el string "aeiou" o mejor dicho
                                                        // verificamos si el caracter es una vocal (incluyendo vocales con tilde)
                    {
                        contadorVocales++; // si la letra ingresada esta en el string o es una vocal se usa un contador para sumar cada vocal que se ingrese
                    }
                    else
                    {
                        contadorConsonantes++; // si en caso no es una vocal o no esta en ese string se entiende que es un consonante y por ende
                        // igual que las vocales se cuenta cada vez que se ingresa una consonante
                    }
                }
            }
            Console.WriteLine($"La cantidad de vocales en el texto es {contadorVocales} y la cantidad de consonantes es {contadorConsonantes}");
            // Mostramos el conteo final de vocales y consonantes
        }
    }
}
