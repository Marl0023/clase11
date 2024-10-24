Console.WriteLine("Se genera datos");
Random rnd = new Random();
int n = 0;
Console.WriteLine("Cuantos datos desea ingresar");
n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
for (int i = 0; i < numeros.Length; i++) { 
    numeros[i] = rnd.Next(0, 50);
}
foreach (int numero in numeros) {
    Console.Write(numero+"\t");
}