using System.Diagnostics.CodeAnalysis;


do
{
    Console.WriteLine("Gire los dados");
    Console.WriteLine("Presione [ESPACIO]");
    Console.ReadKey();
    Random rnd = new Random();
    int dado1 = rnd.Next(1, 7);
    int dado2 = rnd.Next(1, 7);
    int suma = dado1 + dado2;
    if (suma == 7 || suma == 11)
    {
        Console.WriteLine("Ganaste");
        Console.WriteLine("Sacaste: "+suma);
        break;
    }
    if (suma == 2 || suma == 3 || suma == 12)
    {
        Console.WriteLine("Craps!, perdiste");
        Console.WriteLine("Sacaste: " + suma);
        break;
    }
    if (suma == 4 || suma == 5 || suma == 6 || suma == 8 || suma == 9 || suma == 10)
    {
        Console.WriteLine("Again!");
        Console.WriteLine("Sacaste: " + suma);
    }
}while (true);