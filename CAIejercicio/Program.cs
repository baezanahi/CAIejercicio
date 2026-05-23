namespace CAIejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CONFIGURACIÓN ---
            // Pon aquí los últimos 3 dígitos de tu registro
            int registro = 015;

            // Lógica: Si empieza con 0, le sumamos 100
            if (registro < 100)
            {
                registro += 100;
            }

            Console.WriteLine($"Contando hasta el {registro}:");
            Console.WriteLine("--------------------------");

            // --- BUCLE DEL 1 AL REGISTRO ---
            for (int i = 1; i <= registro; i++)
            {
                string etiqueta = "";

                // Lógica de múltiplos
                if (i % 3 == 0 && i % 5 == 0)
                {
                    etiqueta = " – FooBar";
                }
                else if (i % 3 == 0)
                {
                    etiqueta = " – Foo";
                }
                else if (i % 5 == 0)
                {
                    etiqueta = " – Bar";
                }

                // Mostrar el número y su etiqueta (si tiene)
                Console.WriteLine($"{i}{etiqueta}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }


 
      
}
