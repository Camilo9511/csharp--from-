// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*clases
var rect= new rectangulo();
rect.base= 20;
rect.altura=40;

Console.WriteLine($"el area es: {rect.area()}");
Console.WriteLine($"el perimetro  es: {rect.perimetro()}");

end clases*/


var cuadr = new cuadrado();
cuadr.Lado = 20;

Console.WriteLine($"El área es: {cuadr.area()}");
Console.WriteLine($"El perímetro es: {cuadr.perimetro()}");
Console.WriteLine($"El lado es: {cuadr.Lado}");


class rectangulo
{
    public double Base { get; set; }  
    public double Altura { get; set; } 

    public virtual double area() => Base * Altura; 
    public virtual double perimetro() => 2 * (Base + Altura); 
}


class cuadrado : rectangulo
{
    public double Lado
    {
        set
        {
            Base = value; 
            Altura = value; 
        }
        get
        {
            return Base; 
        }
    }

   
    public override double area() => Lado * Lado;
    public override double perimetro() => 4 * Lado;
}


