int cantedad = 0, suma = 0;
bool correcto;
do
{
    Console.WriteLine("Ingrese cantidad de numeros desea ingresar");
    correcto = int.TryParse(Console.ReadLine(), out cantedad);
    if (!correcto)
    {
        Console.WriteLine("Ingrese un numero valido");
    }
    else if (cantedad <= 0)
    {
        Console.WriteLine("Ingrese un numero mayor a cero");
        correcto = false;
    }
} while (!correcto || cantedad <= 0);
int[] numeros = new int[cantedad];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese el numero");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];
}
Console.WriteLine("La suma de los numeros es: " + suma);