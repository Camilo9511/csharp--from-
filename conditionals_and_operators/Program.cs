// See https://aka.ms/new-console-template for more information

/*conditionals*/
//Console.WriteLine("ingrese un numero");
//int num= int.Parse(Console.ReadLine());

//if( num >0) Console.WriteLine("positivo");
//else if (num < 0) Console.WriteLine("negativo");
//else Console.WriteLine("es cero");

/*operators*/

Console.WriteLine("ingrese el primer numero");

double a = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero");
double b = double.Parse(Console.ReadLine());

const string Indeterminado = "indeterminado";
Console.WriteLine($"suma:{a+b}, resta: {a-b}, multiplicacion: {a*b}, division: {(b!=0 ? a/b : Indeterminado)}");