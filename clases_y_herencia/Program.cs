class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione la figura:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("Escriba 'EXIT' para salir.");
            Console.Write("Opción: ");
            
            string opcion = Console.ReadLine();

            if (opcion.ToUpper() == "EXIT") 
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            switch (opcion)
            {
                case "1":
                    double baseRect = PedirNumero("Ingrese la base del rectángulo: ");
                    double alturaRect = PedirNumero("Ingrese la altura del rectángulo: ");

                    Rectangulo rect = new Rectangulo(baseRect, alturaRect);
                    Console.WriteLine($"Área del rectángulo: {rect.CalcularArea()}");
                    Console.WriteLine($"Perímetro del rectángulo: {rect.CalcularPerimetro()}");
                    break;

                case "2":
                    double ladoCuadrado = PedirNumero("Ingrese el lado del cuadrado: ");

                    Cuadrado cuadr = new Cuadrado(ladoCuadrado);
                    Console.WriteLine($"Área del cuadrado: {cuadr.CalcularArea()}");
                    Console.WriteLine($"Perímetro del cuadrado: {cuadr.CalcularPerimetro()}");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static double PedirNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero) && numero > 0)
                return numero;
            
            Console.WriteLine("Por favor, ingrese un número válido mayor que 0.");
        }
    }
}

// Clase base: Rectángulo
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double baseRect, double altura)
    {
        Base = baseRect;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

// Clase derivada: Cuadrado
class Cuadrado : Rectangulo
{
    public Cuadrado(double lado) : base(lado, lado) { }
}