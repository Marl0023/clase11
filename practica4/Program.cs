int[] numeros = { 4, 8, 10, 25 };
Console.WriteLine("Lista Original: ");
foreach (int i in numeros)
{
    Console.WriteLine(i+"\t");
}
numeros[2] = 36;
Console.WriteLine("Lista modificada");
foreach (int o in numeros) { 
    Console.WriteLine(o + "\t");
}