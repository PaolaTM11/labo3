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
int nuevoValor = int.Parse(Console.ReadLine());
numeros[2] = nuevoValor;

Console.WriteLine("Arreglo después de la modificación:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Posición {i}:{numeros[i]}");
}
Console.WriteLine();
//4.Buscar un número y ver si existe en el arreglo
Console.Write("\nIngresa el número que quieres buscar: ");
int numbuscado = int.Parse(Console.ReadLine());
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

