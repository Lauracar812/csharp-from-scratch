namespace itm.csharp.basic
{
    public static class Challenges
    {
        public static void Challenge2()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El mayor es: {Math.Max(num1, num2)}");
        }

        public static void Challenge3()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"El cuadrado es: {num * num}");
        }

        public static void Challenge4()
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"El área es: {Math.PI * Math.Pow(radio, 2):F2}");
        }

        public static void Challenge5()
        {
            string[] dias = {"", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};
            Console.Write("Ingrese un número entre 1 y 7: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num >= 1 && num <= 7 ? $"El día es: {dias[num]}" : "Número inválido");
        }

        public static void Challenge6()
        {
            Console.Write("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 1000 ? salario * 0.1 : 0;
            Console.WriteLine(impuesto > 0 ? $"Debe pagar un impuesto de: {impuesto:F2}" : "No debe pagar impuestos.");
        }

        public static void Challenge7()
        {
            Console.Write("Ingrese el dividendo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num2 != 0 ? $"El resultado es: {num1 / num2:F2}" : "No se puede dividir por cero");
        }

        public static void Challenge8()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
                suma += i;
            Console.WriteLine($"La suma de los números impares entre 1 y 100 es: {suma}");
        }

        public static void Challenge9()
        {
            Console.Write("Ingrese numerador de la primera fracción: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese denominador de la primera fracción: ");
            int den1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numerador de la segunda fracción: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese denominador de la segunda fracción: ");
            int den2 = int.Parse(Console.ReadLine());

            Fraccion f1 = new Fraccion(num1, den1);
            Fraccion f2 = new Fraccion(num2, den2);
            Fraccion resultado = f1.Sumar(f2);
            Console.WriteLine($"La suma es: {resultado.Numerador}/{resultado.Denominador}");
        }

        public static void Challenge10()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine($"Palabra invertida: {new string(palabra.Reverse().ToArray())}");
        }

        public static void Challenge11()
        {
            Console.Write("Ingrese tres números separados por espacio: ");
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine($"El promedio es: {nums.Average():F2}");
        }

        public static void Challenge12()
        {
            Console.Write("Ingrese cinco números separados por espacio: ");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine($"El mayor número es: {nums.Max()}");
        }

        public static void Challenge13()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine(palabra.SequenceEqual(palabra.Reverse()) ? "Es un palíndromo" : "No es un palíndromo");
        }

        public static void Challenge14()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Es par" : "Es impar");
        }

        public static void Challenge15()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num >= 0 && num <= 10 ? "Está en el rango" : "No está en el rango");
        }
    }

    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        
        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }
        
        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNum = (Numerador * otra.Denominador) + (otra.Numerador * Denominador);
            int nuevoDen = Denominador * otra.Denominador;
            return new Fraccion(nuevoNum, nuevoDen);
        }
    }
}

