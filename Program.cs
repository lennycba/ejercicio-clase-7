
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("|A CONTINUACIÓN SE LE PEDIRÁ INGRESAR 10 NÚMEROS UNO A UNO|");
Console.WriteLine("-----------------------------------------------------------");
int[] numeros = new int[10];
int suma = 0;

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--------------------------");
    Console.WriteLine("introduzca el " + (i + 1) + "º número");
    Console.WriteLine("--------------------------");
    Console.ResetColor();
    numeros[i] = int.Parse(Console.ReadLine());
}

int numeroMayor = numeros[0];
int numeroMenor = numeros[0];

for (int i = 0; i < 10; i++)
{
    suma += numeros[i];

    if (numeros[i] > numeroMayor)
    {
        numeroMayor = numeros[i];
    }
    if (numeros[i] < numeroMenor)
    {
        numeroMenor = numeros[i];
    }
}
int promedio = suma / numeros.Length;
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("-----------------------------------------");
Console.WriteLine("** La suma de los 10 numeros es " + suma + ".");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("** El mayor de los 10 números es " + numeroMayor + ".");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("** El menor de los 10 números es " + numeroMenor + ".");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("** El promedio de los 10 números es " + promedio + ".");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("** Los 10 numeros ingresados fueron: ");

foreach (int i in numeros) {
 
    Console.WriteLine("* " + i );
}

Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.ResetColor();