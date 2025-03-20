class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para evaluar:");
        int num = int.Parse(Console.ReadLine());
        EvaluarNumero(num);

        Console.WriteLine("\nIngrese dos números para operaciones matemáticas:");
        Console.Write("Primer número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        double b = double.Parse(Console.ReadLine());

        RealizarOperaciones(a, b);
    }

    static void EvaluarNumero(int num)
    {
        if (num > 0)
            Console.WriteLine("El número es Positivo");
        else if (num < 0)
            Console.WriteLine("El número es Negativo");
        else
            Console.WriteLine("El número es Cero");
    }

    static void RealizarOperaciones(double a, double b)
    {
        Console.WriteLine($"Suma: {a + b}");
        Console.WriteLine($"Resta: {a - b}");
        Console.WriteLine($"Multiplicación: {a * b}");

        if (b != 0)
            Console.WriteLine($"División: {a / b}");
        else
            Console.WriteLine("División: Indeterminado (No se puede dividir por cero)");

        Console.WriteLine();
           
    }
}