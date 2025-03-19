
interface IExtraCalculations
{
    double Perimetro();
}


abstract class Figura
{
    public string Nombre { get; set; }
    public abstract double CalcularArea();
}


class Circulo : Figura, IExtraCalculations
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        if (radio <= 0) throw new ArgumentException("El radio debe ser mayor a 0.");
        this.Radio = radio;
        this.Nombre = "Círculo";
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

class Rectangulo : Figura, IExtraCalculations
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)
    {
        if (largo <= 0 || ancho <= 0) throw new ArgumentException("Las dimensiones deben ser mayores a 0.");
        this.Largo = largo;
        this.Ancho = ancho;
        this.Nombre = "Rectángulo";
    }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }

    public double Perimetro()
    {
        return 2 * (Largo + Ancho);
    }
}

class Program
{
    static void Main()
    {
        List<Figura> figuras = new List<Figura>();

        Console.WriteLine("Calculadora de áreas y perímetros. Escribe 'exit' para salir.");

        while (true)
        {
            try
            {
                Console.WriteLine("\nElige una figura: (1) Círculo, (2) Rectángulo, (exit para salir)");
                string opcion = Console.ReadLine().ToLower();

                if (opcion == "exit") break;

                Figura figura = null;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa el radio del círculo: ");
                        double radio = double.Parse(Console.ReadLine());
                        figura = new Circulo(radio);
                        break;

                    case "2":
                        Console.Write("Ingresa el largo del rectángulo: ");
                        double largo = double.Parse(Console.ReadLine());
                        Console.Write("Ingresa el ancho del rectángulo: ");
                        double ancho = double.Parse(Console.ReadLine());
                        figura = new Rectangulo(largo, ancho);
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                figuras.Add(figura);
                Console.WriteLine($"Área de {figura.Nombre}: {figura.CalcularArea():F2}");

                if (figura is IExtraCalculations extra)
                {
                    Console.WriteLine($"Perímetro de {figura.Nombre}: {extra.Perimetro():F2}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingresa un número válido.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }

        Console.WriteLine("\nFiguras ingresadas:");
        foreach (var fig in figuras)
        {
            Console.WriteLine($"{fig.Nombre} - Área: {fig.CalcularArea():F2}");
        }

        Console.WriteLine("Programa finalizado.");
    }
}