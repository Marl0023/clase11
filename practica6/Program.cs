char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine( "Se conocen los vocales: " );
foreach (var vocal in vocales) { 
    Console.Write( vocal+" " );
}
Console.WriteLine("\nQue caracter quiere modificar ? ");
char i = char.Parse( Console.ReadLine().ToLower());
int caracter = Array.IndexOf( vocales, i );
if (caracter != -1)
{
    Console.WriteLine("A que lo quieres cambiar? : ");
    char o = char.Parse(Console.ReadLine().ToLower());
    vocales[caracter] = o;
    Console.WriteLine("\n");
    string todos = string.Join(", ", vocales);
    Console.WriteLine($"Vocales: {todos}");
}else
    Console.WriteLine("No se puede modificar porque no existe");
/*foreach (char final in vocales) { 
    Console.Write( final+" " );
}
*/
Console.WriteLine("\n");
