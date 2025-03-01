using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args) // se usaron 2 tipos de validaciones con TryParse y Try-Catch
        {
            int numero1, numero2; // se declararon las variables
            char operador;
            Console.Write("Ingrese el primer numero: "); // aqui se empleo la validacion con el TryParse

            while (!int.TryParse(Console.ReadLine(), out numero1)) /* donde si el valor ingresado se convierte en numero entero pues sale del bucle y 
                                                                    ya que al ser verdadero y negarlo con el operador(!) hace que salga del bucle
                                                                    en cambio si lo que ingresa es un decimal, texto o espacio vacio al tratar de convertirse 
                                                                    en numero dara error y false y al negar este resultado nos da un true lo que significa que
                                                                    seguira en el bucle hasta que el valor ingresado sea un numero entero*/
            {                                                           
                Console.WriteLine("Valor invalido, tiene que ingresar un numero");
                Console.Write("Ingrese nuevamente el primer numero: ");
            }

            Console.Write("Ingrese el segundo numero: "); // aqui se empleo un Try-Catch
            do
            {
                try
                {
                    numero2 = int.Parse(Console.ReadLine()); // evalua si el numero ingresado es un numero entero, si no es numero entero dara una exception
                    if (numero2 == 0) // si en caso el numero si puedo convertirse en entero aqui se evalua que el numero no sea igual a cero 
                    {
                        Console.WriteLine("Error, no se puede dividir entre cero"); // si es igual a cero se manda un mensaje de error
                        Console.Write("Ingrese nuevamente el segundo numero: "); // y se vuelve a pedir el numero y no cortar el flujo del programa
                    }
                    else
                    {
                        break; // si en caso el valor es un numero y es diferente de cero significa que el valor ingresado es valido y se rompe el ciclo do-while 
                    }
                }
                catch (FormatException) // la exception que nos genera el Try lo captura el Catch pero para ello tenemos que saber que tipo de exception podria arrojar el Try para colocarlo en el Catch
                {
                    Console.WriteLine("Valor invalido, tiene que ingresar un numero"); // al capturar la exception el catch manda un menaje por consola de error
                    Console.Write("Ingrese nuevamente el segundo numero: "); // y vuelve a pedir el valor para que el programa no caiga y siga su flujo normal
                }
            }
            while (true); 

            Console.WriteLine("Seleccione la operacion que desea realizar (+, -, *, /): ");  // aqui se empleo la validacion con el TryParse

            while (!char.TryParse(Console.ReadLine(), out operador) || !"+-*/".Contains(operador)) /* se evalua que el operador ingresado no sea null o vacio y con el metodo
                                                                                                    .Contains() se revise si el operador ingresado esta dentro del
                                                                                                    string al lado del metodo pero ambas condiciones se niegan 
                                                                                                    para que al ingresar un valor invalido este pueda seguir dentro del bucle*/
            {
                Console.WriteLine("Error: El operador ingreado es invalido"); // se manda un mensaje de error por la consola
                Console.Write("Ingrese nuemvamente el operador: "); // y se pide que ingrese otra vez el operador correcto 
            }

            Calcular.OperarNumeros(numero1, numero2, operador); // al tener los valores correctos se usan para llamar al metodo y colocarlos como parametros del mismo.
            
        }
    }
}
