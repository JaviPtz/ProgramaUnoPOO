using System;

namespace CosasUsanPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe Tu nombre");
            string nombrePersona = Console.ReadLine();
            Console.WriteLine("Escribe tu apellido");
            string apellidoPersona = Console.ReadLine();

            Cocina cocina = new Cocina
            {
                Marca = "MABE",
                Tamaño = "Pequeña",
                NumeroOrnillas = 2,
                Estado = true
            };

            Computadora computadora = new Computadora
            {
                Pantalla = "Full HD 8K",
                Procesador = "Intel Core i9-10940X",
                TarjetaRAM = "16 GB ",
                DiscoDuro = "2 Terabyte",
                TarjetVideo = "NVIDIA GTX de 4 GB",
                Estado = true
            };

            Bicicleta bicicletaPersonal = new Bicicleta
            {
                Color = "Negro",
            };

            Cuaderno cuaderno = new Cuaderno
            {
                Forma = "Cuadrado",
                Tamaño = "Pequeño",
                Tipo = "Rayado",
                NumeroHojas = 50,
                Precio = 1
            };

            Persona personaUno = new Persona
            {
                Nombre = nombrePersona,
                Apellido = apellidoPersona,
                MiCocina = cocina,
                MiComputadora = computadora,
                Mibici = bicicletaPersonal,
                MiCuaderno = cuaderno
  
            };

            Bicicleta bicicletaTransporte= new Bicicleta
            {
                Color = "Negro",
                Tipo = "Montañera",
                Tamaño = "Grande",
                Propietario = personaUno
            };

            Cocina ornillas = new Cocina
            {
                NumeroOrnillas = 2,
                Estado = cocina.Estado,
                PropietarioCocina = personaUno
            };


            string saludo = personaUno.Saludar();
            string estadoCocina = personaUno.EncenderCocina();
            string ornillasDisponibles = ornillas.Calentar();
            string cocinar = personaUno.Cocinar();
            string computadoraComprada = personaUno.ComprarComputadora();
            string bicicletaPintada = personaUno.PintarBicicleta();
            string trasporte = bicicletaTransporte.Transportar();
            string anotar = personaUno.Escribir();
            string anuncio = personaUno.Vender(); 

            Console.WriteLine(saludo + "\n");
            Console.WriteLine(estadoCocina + " "+ ornillasDisponibles + "\n");
            Console.WriteLine(cocinar + "\n");
            Console.WriteLine(computadoraComprada + "\n");
            Console.WriteLine(bicicletaPintada + "\n");
            Console.WriteLine(trasporte + "\n");
            Console.WriteLine(anotar + "\n");
            Console.WriteLine(anuncio + "\n");


        }
    }
}
