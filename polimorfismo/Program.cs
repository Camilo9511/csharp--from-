
// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

var circ = new circulo();
circ.Radio = 20;

var result_area = circ.area();
var result_perim = circ.perimetro();

Console.WriteLine($"El área es: {result_area} y el perímetro es: {result_perim} el nuevo radio es: {circ.add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

Console.WriteLine(); 


try
{
    Console.WriteLine("Número a dividir:");
    double n = double.Parse(Console.ReadLine());

    Console.WriteLine("Divisor:");
    double divisor = double.Parse(Console.ReadLine());

    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    Console.WriteLine($"Resultado: {n / divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero.");
}
catch (Exception)
{
    Console.WriteLine("Error desconocido.");
}

interface IExtraCalculation
{
    double add10();
}

interface Ifigura
{
    double area();
    double perimetro();
}

class circulo : Ifigura, IExtraCalculation
{
    public double Radio { get; set; }

    public double area() => Math.PI * Radio * Radio;

    public double perimetro() => 2 * Math.PI * Radio;

    public double add10()
    {
        return Radio + 10;
    }
}
