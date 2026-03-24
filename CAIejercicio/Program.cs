namespace CAIejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CONFIGURACIÓN ---
            int registro = 015; // Reemplaza con tus 3 dígitos

            if (registro < 100)
            {
                registro += 100;
            }

            Console.WriteLine($"Analizando números hasta el {registro}:");
            Console.WriteLine("-------------------------------------");

            // --- BUCLE PRINCIPAL ---
            for (int i = 1; i <= registro; i++)
            {
                bool esDivisiblePor3 = (i % 3 == 0);
                bool esPrimo = EsPrimo(i);

                // --- LÓGICA DE MENSAJES ---
                if (esPrimo && esDivisiblePor3)
                {
                    Console.WriteLine($"{i} - Es primo y divisible por 3");
                }
                else if (esPrimo)
                {
                    Console.WriteLine($"{i} - Es primo");
                }
                else if (esDivisiblePor3)
                {
                    Console.WriteLine($"{i} - Es divisible por 3");
                }
                else
                {
                    // Si no cumple nada, solo mostramos el número
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // --- FUNCIÓN PARA SABER SI UN NÚMERO ES PRIMO ---
        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false; // El 1 no es primo
            if (numero == 2) return true;  // El 2 es el único primo par

            for (int x = 2; x * x <= numero; x++)
            {
                if (numero % x == 0) return false; // Si alguien lo divide, no es primo
            }
            return true;
        }
    }
}
