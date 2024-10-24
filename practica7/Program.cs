using System.Drawing;

char resp;
int posicion = 0;
int[] num = new int[0];
do
{
    int datos;
    
    Console.WriteLine("Ingrese un numero: ");
    while (!int.TryParse(Console.ReadLine(), out datos)) {
        Console.Write("Error: ingrese un numero entero: ");
    }
    Array.Resize(ref num, num.Length+1);
    num[posicion]=datos;
    posicion++;
    do
    {
        Console.WriteLine("Desea continuar? (S/N)");
        resp = char.Parse(Console.ReadLine().ToUpper());
    }while (resp != 'S' && resp !='N' ); 
}while(resp == 'S');
foreach (int o in num)
{
    Console.Write(o + "\t");
}


Console.WriteLine("Fin");