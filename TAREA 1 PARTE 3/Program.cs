using System.Runtime.InteropServices;

{
    //CADENA DE TEXTO IMPRIMIDA EN MAYUSCULAS
   
Console.WriteLine("Ingrese cualquier palabra o texto en minusculas:");
    string text1 = Console.ReadLine();
    text1 = text1.ToUpper();
    Console.WriteLine("Este es su texto en minusculas:"+text1);
}

{
    //CADENA DE TEXTO IMPRIMIDA EN MINUSCULAS
    Console.WriteLine("Ingrese cualquier palabra o texto en mayusculas:");
    string text1 = Console.ReadLine();
    text1 = text1.ToLower();

    Console.WriteLine("Este es su texto en MAYUSCULAS:"+text1);
}
