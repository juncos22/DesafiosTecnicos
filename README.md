# 3 Proyectos de Desafios Técnicos

Este repositorio consiste en 3 proyectos desarrollados con C# en .NET 5.
Los dos primeros proyectos fueron desarrollados en consola y el tercero se 
realizó con Blazor y ASP .NET Core.

### - Primer Proyecto: Simplificar Fracciones
El primer proyecto consiste en un programa de consola donde se busca simplificar
en su mínima expresión a una fracción determinada.
La función recibe la fracción en formato cadena o string, para luego separar el 
numerador y denominador por medio del caracter '/'. 

~~~
var numeros = fraccion.Split('/');
~~~

Esto hará que nos devuelva
un arreglo de string el cual, posteriormente, se guardarán sus elementos en 
variables de tipo entero o int. De esta forma se obtienen el numerador y denominador 
por separado para poder realizar los calculos necesarios:

~~~
int numerador = int.Parse(numeros[0]);
int denominador = int.Parse(numeros[1]);
~~~

* Primero se evalua si el numerador y denominador son divisibles entre sí, es decir, que el resto de su cociente sea cero. En caso de ser así, devolverá directamente el resultado de la división de ambos:

~~~
if (numerador % denominador == 0)
{
   return $"{numerador / denominador}";
}
~~~

* Si el paso anterior no se dió, entonces procederá a calcular el Minimo Común Divisor de la fracción. Se creó un método especifico para realizar este cálculo, la cual recibe como parámetros al numerador y denominador con formato int o entero.
* Esta función lo que va a hacer es ir calculando el resto de la división entre el numerador y el denominador. Mientras tanto, va a evaluar que el valor del denominador sea diferente de 0. Mientras esta condición se cumpla, se mantendrá calculando el resto del cociente entre el numerador y el denominador, para luego intercambiar los valores de las variables n (numerador), d (denominador) y el resto. El valor del denominador pasara al numerador, mientras que el valor del resto se asignará a la variable del denominador.
* Una vez que el resto quedó en 0 en la última vuelta, el denominador recibira este valor, mientras que el numerador se quedará con el valor buscado, es decir, el Mínimo Común Denominador. En este punto el ciclo se terminará y la función devolverá el valor buscado:

~~~
static int Mcd(int n, int d)
{
    int resto;
    while (d != 0)
    {
        resto = n % d;
        n = d;
        d = resto;
    }
    return n;
}
~~~

* Una vez realizado el calculo correspondiente, se captura el MCD en una variable de tipo entero la cual será usada para simplificar en su mínima expresión a la fracción solicitada:

~~~
int mcd = Mcd(numerador, denominador);
~~~

* En el siguiente y último paso, se procede a dividir al numerador y denominador por el valor obtenido por la función anterior, obteniendo de esta forma la fracción simplificada, para luego devolver el resultado en formato cadena o string:

~~~
numerador /= mcd;
denominador /= mcd;

return $"{numerador}/{denominador}";
~~~

-------------------------------------------------------------------------------------

### - Segundo Proyecto: Controlar Nombres
Este proyecto consiste en una aplicación de consola para validar diferentes estandards o formas específicas de ingresar un nombre. Consiste en ingresar una cadena de texto o string, la cual obtendrá un nombre completo, es decir, un nombre y apellido o un primer y segundo nombre y un apellido. El objetivo de este proyecto es validar que el nombre ingresado respete estos estandares aplicados para que el nombre se considere válido. La función encargada de esto recibirá esta cadena de texto y devolverá un valor booleano el cual confirmará si se ingresó un nombre válido o no.

Para esto se crearon diferentes funciones para validar estos patrones, de esta forma, el código de la función principal será mas legible.

###### Función EsNombreCompleto(string palabra) : bool
Lo que hará esta función será evaluar que la longitud del nombre sea igual o mayor a 2 y que la palabra no contenga un punto en ningún caracter de la misma. De ser así, el nombre devolverá <true> o verdadero, de lo contrario devolverá <false> o falso:

~~~
static bool EsNombreCompleto(string palabra)
{
    var esNombre = palabra.Length >= 2 && !palabra.Contains('.');
    return esNombre;
}
~~~

###### Función EstaCapitalizada(string palabra) : bool
Esta función validará que la palabra ingresada este capitalizada, es decir, que su letra inicial sea mayúscula. Para esto se realizará una operación donde se comparará la primera letra de la palabra con su versión en mayúscula, para esto se debe convertir el primer caracter de la misma en cadena o <string>. Si esto es así, la función devolverá <true>, de lo contrario, devolverá <false>:

~~~
static bool EstaCapitalizada(string palabra)
{
    var estaCapitalizada = palabra[0].ToString() == palabra[0].ToString().ToUpper();
    return estaCapitalizada;
}
~~~

###### Función EsInicial(string palabra) : bool
Esta función corroborará si la palabra está escrita en su forma de inicial.
Para esto evaluará que la longitud de la palabra sea de 2 caracteres solamente, y que el segundo caracter de la palabra sea un punto. Se ser así, la función devolverá <true>, de lo contrario devolverá <false>.
~~~
static bool EsInicial(string palabra)
{
    var esInicial = palabra.Length == 2 && palabra[1] == '.';
    return esInicial;
}
~~~

###### Función ValidarNombre(string nombre) : bool
Esta es la función principal, la cual evaluará que la cadena principal, es decir, el nombre completo ingresado, sea un nombre válido. Por lo tanto, y en base al resultado obtenido de las funciones anteriores, irá evaluando todas y cada una de las posibilidades para que se considere correcta la entrada de texto:

1. Primero guardara la entrada de texto como un arreglo de palabras separado por los espacios, además se creará una variable booleana que guarde el resultado final.
2. Se valida que el nombre posea 2 o más caracteres, de lo contrario no se considerará un nombre válido.
3. En caso de que la entrada contenga solo 2 valores, se evaluarán las siguientes condiciones:
~~~
if (palabras.Length == 2)
{
~~~
4. Luego comienzan a validarse todas las posibilidades que puedan llegar a ocurrir con el formato de la cadena ingresada:
    * Si el primer valor y el segundo estan capitalizados, pasará a evaluar la siguiente condición.
    ~~~
    if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]))
    {
    ~~~
    * Si ambas palabras son nombres completos, la variable <nombreValido> recibirá el valor <true>, de lo contrario continuará con la siguiente condición.
    ~~~
     if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1]))
     {
        nombreValido = true;
     }
    ~~~
    * Si la primera palabra es inicial y la segunda no lo es, la variable <nombreValido> será <true>, de lo contrario será <false>.
    ~~~
    else if (EsInicial(palabras[0]) && !EsInicial(palabras[1]))
    {
        nombreValido = true;
    }
    else
    {
        nombreValido = false;
    }
    ~~~
    * En caso de que ninguna de las condiciones anteriores se haya dado, el valor de la variable nombreValido será <false>.
    ~~~
     else
     {
        nombreValido = false;
     }
    ~~~
5. En caso de que la entrada contenga 3 palabras, se ejecutarán las siguientes condiciones:
~~~
else if (palabras.Length == 3)
{
~~~
6. En este punto, comenzará a evaluar que las 3 palabras cumplan con las siguientes condiciones:
    * En caso de que las 3 palabras estén capitalizadas, pasará a evaluar la siguiente condición, de lo contrario <nombreValido> automáticamente será <false>.
    ~~~
     if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]) 
    && EstaCapitalizada(palabras[2]))
    {
    ~~~
    * Si las 3 palabras son nombres completos, <nombreValido> será <true>, de lo contrario pasará a evaluar la siguiente condición.
    ~~~
    if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1])
        && EsNombreCompleto(palabras[2]))
        {
            nombreValido = true;
        }
    ~~~
    * Si la primera y segunda palabra son iniciales, pero la tercera no lo es, se considerará un nombre válido, de lo contrario pasará a la siguiente condición.
    ~~~
     else if (EsInicial(palabras[0]) && EsInicial(palabras[1]) &&           !EsInicial(palabras[2])) 
     {
            nombreValido = true;
     }
    ~~~
    * Si la primera palabra no es inicial y es un nombre completo, la segunda es inicial pero la tercera no lo es, el nombre será válido, de lo contrario, se considerará nombre no válido.
    ~~~
    else if (!EsInicial(palabras[0]) && EsNombreCompleto(palabras[0]) && EsInicial(palabras[1]) && !EsInicial(palabras[2])) 
    {
        nombreValido = true;
    }
    else
    {
        nombreValido = false;
    }
    ~~~
7. En este punto, si no pasó ninguna evaluación lógica, el nombre se va a considerar no válido.
~~~
     else
     {
        nombreValido = false;
    }
}
else 
{
    nombreValido = false;
}
~~~
8. Finalmente, se devuelve el valor de la variable <nombreValido>.
~~~
    return nombreValido;
}
~~~

#### Código completo:
~~~
/// <summary>
/// Funcion donde se evalua el nombre completo
/// </summary>
/// <param name="nombre">El nombre completo a evaluar</param>
/// <returns>
/// Si el nombre pasa todas las validaciones y posibilidades logicas, devolvera True.
/// De lo contrario devolvera False.
/// </returns>
public static bool ValidarNombre(string nombre)
{
   // Se divide la palabra, separandola por los espacios en blanco.
   // De esta forma se creara un arreglo de cadenas de texto.
   var palabras = nombre.Split(' ');
   // Variable para validar el nombre
   bool nombreValido;

   // Como solamente se permiten 2 o 3 entradas, se evalua que las mismas 
   // Sean mayores a 1
   if (palabras.Length == 2)
   {
    // La primera posibilidad es igual para todas las palabras,
    // Deben estar capitalizadas sin ninguna excepción, de lo contrario se 
    // asigna directamente False a la variable 'nombreValido'.
        if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]))
        {
            // La siguiente posibilidad sera que las 2 palabras sean nombres completos, 
            // de lo contrario evalua la siguiente posibilidad.
            if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1]))
            {
                nombreValido = true;
            }
            else if (EsInicial(palabras[0]) && !EsInicial(palabras[1]))
            {
                // En la siguiente posibilidad se evalua que la primera palabra sea una inicial
                // pero que la segunda no lo sea, debido a que los apellidos no pueden ser iniciales 
                // en este caso, de lo contrario el nombre sera inválido.
                nombreValido = true;
            }
            else
            {
                nombreValido = false;
            }
        }
        else
        {
            nombreValido = false;
        }
    }
    else if (palabras.Length == 3)
    {
        // En el caso de que las palabras sean 3, se validan de la misma forma que 
        // las otras, que esten capitalizadas cada una, sin excepción,
        // de lo contrario el nombre sera inválido de entrada.
        if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]) 
            && EstaCapitalizada(palabras[2]))
            {
               // Al igual que los nombres de 3 palabras, se evalua si son nombres completos,
               // de ser asi, el nombre será valido, de lo contrario buscara la siguiente posibilidad.
               if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1])
                && EsNombreCompleto(palabras[2]))
                {
                    nombreValido = true;
                }
                else if (EsInicial(palabras[0]) && EsInicial(palabras[1])
                && !EsInicial(palabras[2]))  
                {
                    // En la siguiente posibilidad, evalua si las 2 primeras
                    // palabras son iniciales, pero la 3ra no, en caso de 
                    // ser asi el nombre sera valido, de lo contrario
                    // pasa a la siguiente posibilidad
                    nombreValido = true;
                }
                else if (!EsInicial(palabras[0]) && EsNombreCompleto(palabras[0]) 
                 && EsInicial(palabras[1]) && !EsInicial(palabras[2])) 
                    {                               
                    // La ultima posibilidad será que el primer nombre
                    // no sea una inicial y que sea un nombre completo
                    // ademas de que el segundo nombre sea inicial, y 
                    // el apellido no lo sea, de lo contrario 
                    // el nombre ingresado será invalido.
                        nombreValido = true;        
                    }                               
                    else                            
                    {
                        nombreValido = false;
                    }
                }
                else
                {
                    nombreValido = false;
                }
            }
            else 
            {
                nombreValido = false;
            }

    return nombreValido;
}
~~~