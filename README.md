## 3 Proyectos de Desafios Técnicos

Este repositorio consiste en 3 proyectos desarrollados con C# en .NET 5.
Los dos primeros proyectos fueron desarrollados en consola y el tercero se 
realizó con Blazor y ASP .NET Core.

#### - Primer Proyecto: Simplificar Fracciones
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
