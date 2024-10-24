char resp ;
do {
    int i = 0 ;
    Console.WriteLine("Ingrese cuantos valores desea tener");
    i = int.Parse(Console.ReadLine());
    int[] numeros = new int[i];
    for (int j = 0; j < numeros.Length; j++)
    {
        do
        {
            Console.WriteLine("Ingrese un numero entero que obtenga el valor [{0}]", j);
            numeros[j] = int.Parse(Console.ReadLine());

        }while (numeros[j] > 0);
    }






    do
    {
        Console.WriteLine("Desea continuar? (S/N)");
        resp = char.Parse(Console.ReadLine().ToUpper());
    }while (resp != 'S' && resp !='N' ); 
}while(resp == 'S');
Console.WriteLine("Fin");