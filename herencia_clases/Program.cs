// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*clases
var rect= new rectangulo();
rect.base= 20;
rect.altura=40;

Console.WriteLine($"el area es: {rect.area()}");
Console.WriteLine($"el perimetro  es: {rect.perimetro()}");

end clases*/

var cuadr= new cuadrado();
cuadr.base= 20;
cuadr.altura=40;

Console.WriteLine($"el area es: {cuadr.area()}");
Console.WriteLine($"el perimetro  es: {cuadr.perimetro()}");
Console.WriteLine($"el lado  es: {cuadr.lado()}");

class rectangulo {
    public double base{get; set;}

    public double altura{get; set;}

    public double area () => base* altura;

    public double perimetro () => 2*base*altura;
    
    
    

}

class cuadrado : rectangulo{
    public double lado{
        set{ base= value; altura=value;}
        get {return:base;}
    }
}


