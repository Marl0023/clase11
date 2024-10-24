string[] familia = { "jose", "oscar","carmen", "alexa"};
Console.WriteLine("Ingrese un nombre a buscar");
string bnombre = Console.ReadLine().ToLower();
foreach (string integrante in familia) {

    if (integrante == bnombre)
    {
        Console.WriteLine("El nombre {0} que busca si se enceuntra en la lista ", integrante);
        int index = Array.IndexOf(familia, bnombre);
        Console.WriteLine("El nombre se encuentra en la casilla numero " + index);
        Environment.Exit(0);
    }
}
Console.WriteLine("Nombre no encontrado");
