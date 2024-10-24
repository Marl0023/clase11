char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine( "Se conocen los vocales: " );
foreach (var vocal in vocales) { 
    Console.Write( vocal+" " );
}
Console.WriteLine("\nQue caracter quiere modificar ? ");
char i = char.Parse( Console.ReadLine().ToLower());
int caracter = Array.IndexOf( vocales, i );
Console.WriteLine("A que lo quieres cambiar? : ");
char o = char.Parse( Console.ReadLine().ToLower());
vocales[caracter] = o;
Console.WriteLine("\n");
/*foreach (char final in vocales) { 
    Console.Write( final+" " );
}
*/
Console.WriteLine("\n");
string todos = string.Join(", ", vocales);
Console.WriteLine($"Numeros: {todos}");