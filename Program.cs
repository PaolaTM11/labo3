﻿//ETAPA1
//Declarar e inicializar 
int[] numeros = {56,12,6,76,42,4,21,34,31,61};

//Recorremos e imprimimos los 10 elementos

for (int i=0;i<numeros.Length;i++)
{
    Console.WriteLine($"Posición {i}:{numeros[i]}");
}

//Modificar el tercer elemento con un nuevo valor ingresado por el usuario
Console.Write("\nIngresa el nuevo valor para el tercer elemento:");
int nuevoValor = int.Parse(Console.ReadLine()!);
numeros[2] = nuevoValor;

Console.WriteLine("Arreglo después de la modificación:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Posición {i}:{numeros[i]}");
}
Console.WriteLine();
//4.Buscar un número y ver si existe en el arreglo
Console.Write("\nIngresa el número que quieres buscar: ");
int numbuscado = int.Parse(Console.ReadLine()!);
bool numencontrado = false;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numbuscado)
    {
        Console.WriteLine("El número " + numbuscado + " SÍ existe, en la posición " + i + ".");
        numencontrado = true;
        break;
    }
}
if (!numencontrado)
{
    Console.WriteLine("El número " + numbuscado + " NO existe en el arreglo.");
}
//ETAPA 2
//1.Declaramos e inicializamos la matriz 3x3
int[,] matriz = new int[3,3];
//2.Llenamos la matriz con números ingresados por el usuario
for (int fila=0;fila<3;fila++)
{
    for (int columna=0;columna<3;columna++)
    {
        Console.WriteLine($"Ingresa el valor para la posición [{fila},{columna}]");
        matriz[fila,columna]=int.Parse(Console.ReadLine());
        
    }
}
//3.Mostrar la matriz con un bucle anidado
Console.WriteLine("Matriz ingresada:");
for (int fila=0;fila<3;fila++)
{
    for (int columna=0;columna<3;columna++)
    {
        Console.Write($"{matriz[fila,columna]}");
    }
    Console.WriteLine();
}

//4.Calcular la suma total de todos los elementos
int sumaTotal = 0;
for (int fila=0;fila<3;fila++)
{
    for (int columna=0;columna<3;columna++)
    {
        sumaTotal += matriz[fila,columna];
    }
}
Console.WriteLine("\nLa suma total de los elementos es: " + sumaTotal);

// ETAPA 3
//1.Declaramos la lista dinámica con 4 elementos inciales
List<int> listaNumeros=new List<int>(){10,20,30,45,50};
Console.WriteLine();
Console.WriteLine("Lista inicial:");
for (int i  = 0;i<listaNumeros.Count;i++)
{
    Console.WriteLine($"Posición {i + 1}: {listaNumeros[i]}");
}

//2.Creamos el menú
int opcion = 0;
while (opcion !=5)
{
    Console.WriteLine("\n----- MENÚ -----");
    Console.WriteLine("1. Insertar un elemento al final");
    Console.WriteLine("2. Eliminar un elemento por posición");
    Console.WriteLine("3. Buscar un valor y mostrar su posición");
    Console.WriteLine("4. Mostrar la lista actualizada");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            Console.Write("Ingresa el valor a insertar:");
            int valorNuevo=int.Parse(Console.ReadLine());
            listaNumeros.Add(valorNuevo);
            Console.WriteLine($"Se insertó el {valorNuevo} al final de la lista.");
            break;
        case 2:
            
            Console.Write($"Ingresa la posición a eliminar (1 a {listaNumeros.Count}): ");
            int posEliminar = int.Parse(Console.ReadLine());
            if (posEliminar >= 1 && posEliminar <= listaNumeros.Count)
            {
                listaNumeros.RemoveAt(posEliminar - 1);
                Console.WriteLine($"Se eliminó el elemento de la posición {posEliminar}.");
            }
            else
            {
                Console.WriteLine("Posición no válida.");
            }
            break;
        case 3:
            
            Console.Write("Ingresa el valor a buscar: ");
            int valorObjetivo = int.Parse(Console.ReadLine());
            int posEncontrada = -1;

            for (int i = 0; i < listaNumeros.Count; i++)
            {
               if (listaNumeros[i] == valorObjetivo)
               {
                posEncontrada = i;
                break;
               }
            }

            if (posEncontrada != -1)
            Console.WriteLine($"El valor {valorObjetivo} está en la posición {posEncontrada + 1}.");
            else
            Console.WriteLine($"El valor {valorObjetivo} no está en la lista.");
            break;
        case 4:
            Console.WriteLine("Lista actualizada:");
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine($"Posición {i + 1}: {listaNumeros[i]}");
            }
            break;
        case 5:
            Console.WriteLine("Saliendo del menú...");
            break;

        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;


    }
}       
//Etapa 4 
//1.Creamos la lista de manera desordenada
List<int> datos = new List<int>() { 64, 25, 12, 22, 11, 90, 3, 47 };
Console.WriteLine();
Console.WriteLine("Lista desordenada:");
for (int i = 0; i < datos.Count; i++)
{
    Console.Write($"{datos[i]} ");
}
Console.WriteLine();
//2.Ordenamiento burbuja 
List<int>datosBurbuja =new List<int>(datos);
int comparacionesBurbuja=0;
int intercambiosBurbuja=0;

Console.WriteLine("-----ORDENAMIENTO BURBUJA------");
Console.WriteLine("Antes:");
for (int i=0;i<datosBurbuja.Count;i++)
{
    Console.WriteLine($"{datosBurbuja[i]}");
}
Console.WriteLine();

for (int pasada=0;pasada<datosBurbuja.Count-1;pasada++)
{
    for (int i = 0; i < datosBurbuja.Count - 1 - pasada; i++)
    {
        comparacionesBurbuja++;
        if (datosBurbuja[i]>datosBurbuja[i+1])
       {
           int temp=datosBurbuja[i];
           datosBurbuja[i] = datosBurbuja[i + 1];
           datosBurbuja[i + 1] = temp;
           intercambiosBurbuja++;
        }
    }

    Console.Write($"Fin de la pasada {pasada + 1}: ");
    for (int i = 0; i < datosBurbuja.Count; i++)
    {
        Console.Write($"{datosBurbuja[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Después:");
for (int i = 0; i < datosBurbuja.Count; i++)
{
    Console.Write($"{datosBurbuja[i]} ");
}
Console.WriteLine();
//3.Ordenamiento por selección
List<int> datosSeleccion = new List<int>(datos);
int comparacionesSeleccion = 0;
int intercambiosSeleccion = 0;

Console.WriteLine();
Console.WriteLine("--- ORDENAMIENTO POR SELECCIÓN ---");
Console.WriteLine("Antes:");
for (int i = 0; i < datosSeleccion.Count; i++)
{
    Console.Write($"{datosSeleccion[i]} ");
}
Console.WriteLine();

for (int pasada = 0; pasada < datosSeleccion.Count - 1; pasada++)
{
    int posMin = pasada;
    for (int i = pasada + 1; i < datosSeleccion.Count; i++)
    {
        comparacionesSeleccion++;
        if (datosSeleccion[i] < datosSeleccion[posMin])
        {
            posMin = i;
        }
    }

    if (posMin != pasada)
    {
        int temp = datosSeleccion[pasada];
        datosSeleccion[pasada] = datosSeleccion[posMin];
        datosSeleccion[posMin] = temp;
        intercambiosSeleccion++;
    }

    Console.Write($"Fin de la pasada {pasada + 1}: ");
    for (int i = 0; i < datosSeleccion.Count; i++)
    {
        Console.Write($"{datosSeleccion[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Después:");
for (int i = 0; i < datosSeleccion.Count; i++)
{
    Console.Write($"{datosSeleccion[i]} ");
}
Console.WriteLine();
