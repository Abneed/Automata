# Automata

Aplicación de escritorio para Windows que simula el comportamiento de un autómata finito por medio de una matriz o tabla de transiciones, que puede ser ingresado de forma manual por el usuario en el mismo programa o importado desde un archivo de formato .cvs (Comma Separated Values File).


## Almacenamiento de las cadenas

Automata almacena las cadenas que fueron ingresadas al igual de que cual fue el estado final del autómata finito, si fue aceptada o no la cadena, y la clave TOKEN correspondiente al elemento evaluado, mismo que se encuentra en la columna CAT (conversión a token).

## Procedimiento del autómata finito

Automata muestra el procedimiento del automata finito por medio de una hoja de calculo, y va mostrando los estados que se recorrieron dependiendo de la cadena que fue ingresada. 

## Crear tablas de transiciones

Automata te permite crear tablas de transiciones por medio de sus hojas de calculo.

## Abrir tablas de transiciones

Automata permite importa tablas de transiciones desde por medio de archivos en formato .cvs (Comma Separated Values File).

Automata recibe:

- Cadenas (Que tiene que contener nada mas las expresiones regulares de un lenguaje).
- Matriz de Transiciones (lo cual esta representado en forma de tabla, que puede ser importado desde un archivo en formato .cvs).


# Información sobre los autómatas finitos

### ¿Qué es un autómata finito?

Los autómatas finitos consisten en un conjunto de estados controlados por un proceso que se mueve de uno a otros de ellos, respondiendo a las entradas que le correspondan. 
Se dice finitos porque la maquina tiene una cantidad determinada de estados. 
El autómata cuenta con un estado inicial y un estado final, excepto cuando la máquina tiene un estado de inicio que también es estado final, lo cual significa que acepta una cadena de símbolos (vacía).


El autómata se detendrá cuando exista un fin de cadena (FDC). Si el estado en donde se quedó el control del autómata es de aceptación, la cadena de uno o de más de un símbolo se acepta.
Para diseñar un automata finito se requiere de lo siguiente:

* Definiciones regulares.
* Diagramas de transiciones.
* Matriz de transiciones.

### ¿Qué es una definición regular?
Es un conjunto de expresiones regulares (una o varias de ellas) al cual se le adjudica un nombre.

### ¿Qué es una expresión regular?
Las expresiones regulares son oraciones o patrones que cumplen las reglas establecidas por un lenguaje de programación, y ayudan a evaluar una o varias cadenas de entrada para posteriormente categorizar sus elementos y asignarles un token.

### ¿Qué es un token?
Token es el nombre o clave que se da a cada una de las categorias de un lenguaje de programación.

### ¿Qué es un diagrama de transiciones?
Es la representación gráfica de un autómata finito a partir de las definiciones regulares, para una mejor comprensión del autómata mediante un grafo dirigido.

### ¿Qué es una tabla o matriz de transiciones?
Es la manera lógica de expresar la información de un diagrama de transiciones, a tráves de un arreglo bidimensional de filas y columnas, donde:
* Cada fila representa un estado del diagrama de transiciones.
* Cada columna corresponde a uno de los símbolos o categorías de símbolos que componen al alfabeto.
* El valor de la celda correspondiente a la fila *m* y la columna *n* es el número de estado al que se llegaría en un diagrama de transiciones con el símbolo x de la cadena y el estado actual.
* En la última columna de la matriz están representados el FDC (fin de cadena) o el del (delimitador de la cadena), que normalmente corresponden a un espacio en blanco. Los valores que contiene son "ACEPTADA" (si el estado donde quedó el control del autómata es estado de aceptación) o  "ERROR" (cuando se llegó al fin de la cadena leída pero en el diagrama de transiciones no quedó en un estado de aceptación).


## Bibliografía:

Cantú Treviño, Thelma Guadalupe & Mendoza García, María Guadalupe. (2015). Teoría de autómatas. Un enfoqué práctico.. Avenida Antonio Dovalí Jaime #70 Torre B, Piso 6, Colonia Zedec Ed Plaza Santa Fe Delegación Álvaro Obregón, México, Distrito Federal, C.P. 01210: Pearson Educación de México, S.A. de C.V..
