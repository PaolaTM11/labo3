//ETAPA1
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
        matriz[fila,columna]=Convert.ToInt32(Console.ReadLine());
        
    }
}
//3.Mostrar la matriz con un bucle anidado
Console.WriteLine("\nMatriz ingresada:");
for (int fila=0;fila<3;fila++)
{
    for (int columna=0;columna<3;columna++)
    {
        Console.Write(matriz[fila,columna]+ "\t");
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