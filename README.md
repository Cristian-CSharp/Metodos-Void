# Método Void
En C#, un método `void` es aquel que **no devuelve un valor** cuando se ejecuta. Este tipo de método se usa principalmente para ejecutar instrucciones sin necesidad de un resultado de retorno.

Los métodos `void` pueden clasificarse en:

1.  **Métodos `void` sin parámetros** → No reciben valores de entrada.
2.  **Métodos `void` con parámetros** → Reciben valores para ejecutar operaciones internas.


## Método Void sin parámetros
-   No reciben datos de entrada.
-   Se ejecutan y terminan sin devolver un resultado.
-   Son útiles para mostrar mensajes, modificar variables de clase o realizar acciones sin retorno.

📌 **Ejemplo:**
```c#
class Program
{
    static void MostrarSaludo()
    {
        Console.WriteLine("¡Hola, bienvenido a C#!");
    }

    static void Main()
    {
        MostrarSaludo(); // Llamada al método
    }
}
```
📝 **Explicación:**  
El método `MostrarSaludo()` no recibe parámetros y simplemente imprime un mensaje en la consola.

## Método Void con parámetros
-   Reciben datos de entrada para realizar una acción.
-   Son útiles para operaciones personalizadas sin devolver valores.

📌 **Ejemplo:**
```c#
class Program
{
    static void MostrarMensaje(string mensaje)
    {
        Console.WriteLine("Mensaje recibido: " + mensaje);
    }

    static void Main()
    {
        MostrarMensaje("Aprendiendo métodos void en C#");
    }
}
```
📝 **Explicación:**  
El método `MostrarMensaje(string mensaje)` recibe un parámetro y lo imprime en la consola.

## 🏋 Ejercicios :
 🖥️ **Ejercicio 1: Calculadora Simple**
 
Crea un método `void` llamado `OperarNumeros(int num1, int num2, char operacion)`, que reciba dos números y un carácter indicando la operación (`+`, `-`, `*`, `/`).

-   Si la operación es `+`, suma los números y muestra el resultado.
-   Si es `-`, resta los números.
-   Si es `*`, multiplica los números.
-   Si es `/`, divide los números, validando que el divisor no sea 0.
-   Si el operador no es válido, muestra un mensaje de error.

🖥️ **Ejercicio 2: Verificar Palíndromo**

Crea un método `void` llamado `VerificarPalindromo(string palabra)` que reciba una palabra y verifique si es un palíndromo (se lee igual de izquierda a derecha y viceversa).

-   Si la palabra es un palíndromo, imprime `"La palabra es un palíndromo."`
-   Si no lo es, imprime `"La palabra no es un palíndromo."`

🖥️ **Ejercicio 3: Contar Vocales y Consonantes**

Crea un método `void` llamado `ContarLetras(string texto)` que reciba una cadena y cuente la cantidad de vocales y consonantes en ella. Luego, muestra los resultados en consola.

-   Considera que solo se cuentan letras (ignorar espacios y signos de puntuación).
-   Distinguir entre vocales (`a, e, i, o, u`) y consonantes.
---
🔥 Importante
Estos ejercicios, ya están resueltos y los puedes encontrar en este repositorios, cada ejercicio esta en una carpeta...
---
