namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            /*Data Type*/

            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("¡Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es incorrecta, favor verifique el dato que ingreso es: {birthdayInput}");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year

            };

            Console.WriteLine($"tu nombre: {person.Name}");
            Console.WriteLine($"tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"¡tu edad es : {person.Age} años!");




            Console.ReadLine();
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}