using NPrimos.Logic;


var NumeroPrimo = new NumPrimos(10);
Console.WriteLine("ingrese el numero hasta el que desee que se genere");
int n = Convert.ToInt32(Console.ReadLine());
int[] primos = NumPrimos.NumPrimos(n);
Console.WriteLine("Los numeros primos son");
Console.WriteLine(primos);
