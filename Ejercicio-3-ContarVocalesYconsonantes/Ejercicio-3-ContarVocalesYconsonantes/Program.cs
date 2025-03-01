using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ContarVocalesYconsonantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un texto: "); // se manda un mensaje donde el usuario debe ingresar un texto
            string texto = Console.ReadLine().ToLower(); // el texto ingresado se almacenara en la variable texto
             
            Contar.ContarLetras(texto); // se llama al metodo para dar la respuesta
        }
    }
}
