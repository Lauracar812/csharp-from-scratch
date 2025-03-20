namespace itm.csharp.basic
{
    public static class Menu
    {
        public static void MostrarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione un desafío:");
                Console.WriteLine("2: Comparar dos números");
                Console.WriteLine("3: Cuadrado de un número");
                Console.WriteLine("4: Área de un círculo");
                Console.WriteLine("5: Día de la semana");
                Console.WriteLine("6: Cálculo de impuestos");
                Console.WriteLine("7: División de dos números");
                Console.WriteLine("8: Suma de impares entre 1 y 100");
                Console.WriteLine("9: Suma de fracciones");
                Console.WriteLine("10: Invertir palabra");
                Console.WriteLine("11: Promedio de tres números");
                Console.WriteLine("12: Mayor de cinco números");
                Console.WriteLine("13: Verificar palíndromo");
                Console.WriteLine("14: Par o impar");
                Console.WriteLine("15: Verificar rango (0-10)");
                Console.WriteLine("0: Salir");
                Console.Write("Ingrese su elección: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    if (opcion == 0) break;
                    EjecutarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 2: Challenges.Challenge2(); break;
                case 3: Challenges.Challenge3(); break;
                case 4: Challenges.Challenge4(); break;
                case 5: Challenges.Challenge5(); break;
                case 6: Challenges.Challenge6(); break;
                case 7: Challenges.Challenge7(); break;
                case 8: Challenges.Challenge8(); break;
                case 9: Challenges.Challenge9(); break;
                case 10: Challenges.Challenge10(); break;
                case 11: Challenges.Challenge11(); break;
                case 12: Challenges.Challenge12(); break;
                case 13: Challenges.Challenge13(); break;
                case 14: Challenges.Challenge14(); break;
                case 15: Challenges.Challenge15(); break;
                default: Console.WriteLine("Opción inválida. Intente nuevamente."); break;
            }
        }
    }
}
