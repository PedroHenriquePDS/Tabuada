System.Console.WriteLine("----- Tabuada -----");

System.Console.Write("Digite um número que deseja fazer a tabuada: ");

int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int multiplo = 1;
int resultado;


while ( multiplo <= 10)
{
    resultado = numeroDigitado * multiplo;
    System.Console.WriteLine($"{numeroDigitado} X {multiplo} = {resultado}");
    multiplo++;
}

System.Console.Write("Pressione qualquer tecla para fechar");
Console.ReadKey();