# 3 Proyectos de Desafios Técnicos

Este repositorio contiene 3 proyectos desarrollados con C# en .NET 5.
Los dos primeros proyectos fueron desarrollados en consola y el tercero se 
realizó con Blazor y ASP .NET Core.

### - Primer Proyecto: Simplificar Fracciones
El primer proyecto consiste en un programa de consola donde se busca simplificar
a su mínima expresión una fracción determinada.
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
* Una vez que el resto quedó en 0 en la última vuelta, el denominador recibirá este valor, mientras que el numerador se quedará con el valor buscado, es decir, el Mínimo Común Denominador. En este punto el ciclo se terminará y la función devolverá el valor buscado:

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
Este proyecto consiste en una aplicación de consola para validar diferentes estandares o formas específicas de ingresar un nombre. Consiste en ingresar una cadena de texto o string, la cual obtendrá un nombre completo, es decir, un nombre y apellido o un primer y segundo nombre y un apellido. El objetivo de este proyecto es validar que el nombre ingresado respete estos estandares aplicados para que el nombre se considere válido. La función encargada de esto recibirá esta cadena de texto y devolverá un valor booleano el cual confirmará si se ingresó un nombre válido o no.

Para esto se crearon diferentes funciones para validar estos patrones, de esta forma, el código de la función principal será mas legible.

###### Función EsNombreCompleto(string palabra) : bool
Lo que hará esta función será evaluar que la longitud del nombre sea igual o mayor a 2 y que la palabra no contenga un punto en ningún caracter de la misma. De ser así, el nombre devolverá true o verdadero, de lo contrario devolverá false o falso:

~~~
static bool EsNombreCompleto(string palabra)
{
    var esNombre = palabra.Length >= 2 && !palabra.Contains('.');
    return esNombre;
}
~~~

###### Función EstaCapitalizada(string palabra) : bool
Esta función validará que la palabra ingresada este capitalizada, es decir, que su letra inicial sea mayúscula. Para esto se realizará una operación donde se comparará la primera letra de la palabra con su versión en mayúscula, para esto se debe convertir el primer caracter de la misma en cadena o string. Si se cumple la condición, la función devolverá true, de lo contrario, devolverá false:

~~~
static bool EstaCapitalizada(string palabra)
{
    var estaCapitalizada = palabra[0].ToString() == palabra[0].ToString().ToUpper();
    return estaCapitalizada;
}
~~~

###### Función EsInicial(string palabra) : bool
Esta función corroborará si la palabra está escrita en su forma de inicial.
Para esto evaluará que la longitud de la palabra sea de 2 caracteres solamente, y que el segundo caracter de la palabra sea un punto. Se ser así, la función devolverá true, de lo contrario devolverá false.
~~~
static bool EsInicial(string palabra)
{
    var esInicial = palabra.Length == 2 && palabra[1] == '.';
    return esInicial;
}
~~~

###### Función ValidarNombre(string nombre) : bool
Esta es la función principal, la cual evaluará que la cadena principal, es decir, el nombre completo ingresado, sea un nombre válido. Por lo tanto, y en base al resultado obtenido de las funciones anteriores, irá evaluando todas y cada una de las posibilidades para que se considere correcta la entrada de texto:

1. Primero guarda la entrada de texto como un arreglo de palabras separado por los espacios, además se creará una variable booleana que guarde el resultado final.
2. Se valida que el nombre posea 2 o más palabras, de lo contrario no se considerará un nombre válido.
3. En caso de que la entrada contenga solo 2 valores, se evaluarán las siguientes condiciones:
~~~
if (palabras.Length == 2)
{
~~~
4. Luego comienzan a validarse todas las posibilidades que puedan llegar a ocurrir con el formato de la cadena ingresada:
    * Si el primer valor y el segundo estan capitalizados, pasará a evaluar la siguiente condición, de lo contrario la variable nombreValido será false.
    ~~~
    if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]))
    {
    ~~~
    * Si ambas palabras son nombres completos, la variable nombreValido recibirá el valor true, de lo contrario continuará con la siguiente condición.
    ~~~
     if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1]))
     {
        nombreValido = true;
     }
    ~~~
    * Si la primera palabra es inicial y la segunda no lo es, la variable nombreValido será true, de lo contrario será false.
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
    * En caso de que ninguna de las condiciones anteriores se haya dado, el valor de la variable nombreValido será false.
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
    * En caso de que las 3 palabras estén capitalizadas, pasará a evaluar la siguiente condición, de lo contrario nombreValido automáticamente será false.
    ~~~
     if (EstaCapitalizada(palabras[0]) && EstaCapitalizada(palabras[1]) 
    && EstaCapitalizada(palabras[2]))
    {
    ~~~
    * Si las 3 palabras son nombres completos, nombreValido será true, de lo contrario pasará a evaluar la siguiente condición.
    ~~~
    if (EsNombreCompleto(palabras[0]) && EsNombreCompleto(palabras[1])
        && EsNombreCompleto(palabras[2]))
        {
            nombreValido = true;
        }
    ~~~
    * Si la primera y segunda palabra son iniciales, pero la tercera no lo es, se considerará un nombre válido, de lo contrario pasará a la siguiente condición.
    ~~~
     else if (EsInicial(palabras[0]) && EsInicial(palabras[1]) && !EsInicial(palabras[2])) 
     {
        nombreValido = true;
     }
    ~~~
    * Si la primera palabra no es inicial y es un nombre completo, la segunda es inicial pero la tercera no lo es pero es un nombre completo, el nombre será válido, de lo contrario, se considerará nombre no válido.
    ~~~
    else if (!EsInicial(palabras[0]) && EsNombreCompleto(palabras[0]) 
    && EsInicial(palabras[1]) 
    && !EsInicial(palabras[2]) && EsNombreCompleto(palabras[2]))
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
8. Finalmente, se devuelve el valor de la variable nombreValido.
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
                && EsInicial(palabras[1]) 
                && !EsInicial(palabras[2]) && EsNombreCompleto(palabras[2]))
                    {                               
                    // La ultima posibilidad será que el primer nombre
                    // no sea una inicial y que sea un nombre completo
                    // ademas de que el segundo nombre sea inicial, y 
                    // el apellido no lo sea pero sea un nombre completo, de lo contrario 
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
-----------------------------------------------------------------

### - Tercer Proyecto: API Básica
El siguiente proyecto consiste en una API web que maneja información relevante a la pandemia de SarsCoVid-19 ocurrida durante los 2 últimos años. El proyecto consta de la API web, la cual maneja esta información, y la aplicación que consume esta misma.

#### - API Web
La API maneja esta información que, al principio de su desarrollo, se valió del archivo .csv proveído por el sitio oficial del gobierno de Córdoba, el cual se usó para leer sus registros y guardarlos en un archivo de base de datos SQLite portable para facilitar la consulta y registro de nuevos casos.

### Clases principales:
* ApplicationDbContext
* Caso
* CasoViewModel
* BusquedaViewModel
* ListCasoViewModel
* CasoResponse
* CovidController

#### ApplicationDbContext
Esta clase es la encargada de realizar la conexión a la base de datos y manejar el modelo de datos de la clase Caso. Por medio de esta clase se realizan las operaciones a la base de datos (consultas, registros).

#### Caso
Es el modelo de datos que mapea la información de la base de datos, mapeando la tabla Casos en esta misma clase para poder manejar la información en la base de datos. Posee todos los atributos de la tabla (Fecha, Edad, Genero, Provincia).

#### CasoViewModel
Esta clase hace de intermediaria entre el modelo de datos, la lógica de negocio y la vista que interactúa con el usuario. De esta forma, se crea una capa extra que mantiene al usuario sin interacción directa con el modelo de datos.

#### BusquedaViewModel
Esta clase se usa para recibir los parámetros de busqueda que maneje el usuario a la hora de filtrar la informacón que desea consultar. Posee los atributos requeridos para manejar estos filtros (FechaInicio, FechaFin, EdadInicio, EdadFin, Genero, Provincia). Su función es parecida a la de la clase CasoViewModel, separando la logica de negocio del modelo de datos y la vista.

#### ListCasoViewModel
Esta clase se encarga de proveer la información que consulte el usuario a la base de datos. Posee los mismos atributos del modelo de datos de la clase Caso y su función es parecida a la de CasoViewModel y BusquedaViewModel.

#### CasoResponse
Esta clase se encarga de proveer una respuesta al usuario cuando realiza las consultas a la base de datos. Posee 3 atributos importantes: StatusCode, Mensaje y Data. El primer atributo provee un código de estado el cual puede ser 200 (petición exitosa) o 400 (error en la petición). Además el atributo Mensaje se encarga de darle un mensaje notificando al usuario sobre el estado de la respuesta obtenida. Y el atributo Data contiene la lista de objetos de tipo ListCasoViewModel, el cuál será el resultado de una petición exitosa. En caso de obtener una respuesta exitosa, el objeto de tipo CasoResponse almacenará el código 200 y la lista con los resultados que se mostrarán al usuario, en caso de que haya un error en la petición, la respuesta devolverá el codigo 400 y el mensaje de error que se mostrará al usuario.

#### CovidController
Esta es la clase que posee todos los endpoints principales, donde se maneja la clase ApplicationDbContext por medio de la inyección de dependencias y que se encarga de realizar todas las operaciones de la base de datos. Cada endpoint tiene su método donde se realizan las consultas a la API y se devuelve la respuesta con la información.

##### Endpoints
La API contiene los siguientes endpoints de consulta y registro de información:
* /covid
* /covid/total
* /covid/update

##### /covid
-- El primer endpoint se realizó más que nada para consultar la información completa, de manera que se pueda ver el filtrado a la hora de buscar por los diferentes parámetros.

##### /covid/total
-- El segundo endpoint es el que se usará para filtrar por los diferentes parámetros elegidos por el usuario.
Los parametros disponibles son los siguientes:
* FechaInicio
* FechaFin
* EdadInicio
* EdadFin
* Genero
* Provincia

Estos parámetros son pasados por medio de un modelo de vistas o ViewModel llamado BusquedaViewModel, por el cual el usuario envía los parámetros por medio de los atributos de esta clase. Los parámetros de la clase son enviados hacia el método que contiene el endpoint /covid/total donde se van a filtrar los datos por los parametros que reciba y devolverá la respuesta por medio de la clase CasoResponse con la lista de objetos de tipo ListCasoViewModel, además de mostrar el total de casos como la cantidad de items que recibió esta lista.

#### - Blazor UI
La vista está hecha con el framework Blazor y diseñado con Bootstrap donde el usuario interactua con el modelo de vistas (ViewModel) el cual le proveerá la información requerida en sus consultas. Se mantuvo una interfaz simple y concisa la cual consiste en 2 páginas principales:

* Index.razor
* SaveData.razor
  
##### - Index.razor
Esta es la página donde se muestra la información de los casos de Covid 19 y se realizan las consultas por medio de un formulario el cual posee todos los campos del modelo de vistas BusquedaViewModel que será enviado al modelo de datos el cual enviará el valor de los parámetros para poder filtrar en la base de datos. Además se usó la clase HttpClient inyectada en la página para poder realizar las peticiones HTTP GET a la API de forma asíncrona al endpoint /covid/total y obtener la respuesta con el objeto CasoResponse.

##### - SaveData.razor
Esta página es la encargada de guardar los nuevos registros de casos de Covid 19 en la base de datos. Posee un formulario con los campos relacionados al modelo de vistas de la clase CasoViewModel la cual le envía los datos al modelo de datos por medio de una petición HTTP POST asíncrona realizada con la clase inyectada HttpClient la cual realiza la petición al endpoint /covid/update y guarda la información enviada en la base de datos.
Además el modelo de vistas CasoViewModel maneja ciertas validaciones para cada uno de sus atributos, de forma que no le deje al usuario ingresar información errónea o incompleta.

Las validaciones son las siguientes:
* [Required()]
* [Range()]
  
La primer validación se usó en la mayoría de los atributos de la clase CasoViewModel, para evitar campos vacíos en el formulario, mientras que la segunda validación se usó solamente para el atributo Edad, el cual no debe permitir valores menores o iguales a 0 ni mayores a 100 (se manejó una edad promedio aproximada de vida).

Además se agregó una función para limpiar los filtros de búsqueda para facilitar nuevas consultas a la información.