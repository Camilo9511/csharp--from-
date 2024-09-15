namespace Helloworld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted= new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("hola bienvenido al calculador de años");
            Console.WriteLine("escribe tu nombre");
            nameInput=Console.ReadLine();
            Console.WriteLine($"un gusto conocerte {nameInput}");
            Console.WriteLine("escribe tu fecha de nacimiento en formato dd/mm/año");
            birthdayInput=Console.ReadLine();
            bool isDateValid=DateOnly.TryParse(birthdayInput,out dateConverted);
            if(isDateValid==false)  Console.WriteLine($"la fecha de nacimiento es invalida {birthdayInput}" );
            var person= new Person{
                Name= nameInput,
                birthday=dateConverted,
                age= DateTime.Now.Year-dateConverted.Year
   

            };

             Console.WriteLine($"tu nombre: {person.Name}");
             Console.WriteLine($"tu fecha de nacimiento: {person.birthday} ");
             Console.WriteLine($"tu edad es: {person.age} años ");


             Console.ReadLine();



            
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public DateOnly birthday { get; set; }
    }
}