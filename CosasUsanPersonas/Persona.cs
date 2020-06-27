using System;

namespace CosasUsanPersonas
{
    class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set;  }

        public int Edad { get; set; }

        public string Ocupacion { get; set; }


        //relaciones

        public Cocina MiCocina { get; set; }

        public Computadora MiComputadora { get; set; }

        public Bicicleta Mibici { get; set; }

        public Cuaderno MiCuaderno { get; set; }


        public string Saludar()
        
        {
            return $"Hola  {Nombre} {Apellido} ¿Cómo estas?";
        }

        public string EncenderCocina()
        {
            if (MiCocina.Estado == true)
            {
                string prendido = $"Tu {MiCocina.Tamaño} cocina esta Encendida";
                return prendido;
            }
            else
            {
                string apagado = "Rayos mi cocina esta apagada";
                return apagado;
            }

        }
        
        public string Cocinar()
        {
            if (MiCocina.Estado == true)
            {
                string mensajeUno = $"yo {Nombre} voy a cocinar en esta {MiCocina.Tamaño} cocina con {MiCocina.NumeroOrnillas} ornillas encendidas";
                return mensajeUno;
            }
            else
            {
                string mensajeDos = "Bueno sera para la proxima";
                return mensajeDos;
            }
        }

        public string ComprarComputadora()
        {
            if (MiComputadora.Estado == true)
            {
                string mensaje = $"necesito comprar  una computadora con estas especificaiones:" +
                    $"\n Pantalla: { MiComputadora.Pantalla}" +
                    $"\n Procesado: {MiComputadora.Procesador}" +
                    $"\n RAM: {MiComputadora.TarjetaRAM}" +
                    $"\n Disco Duro: {MiComputadora.DiscoDuro} " +
                    $"\n Tarjeta Gráfica: {MiComputadora.TarjetVideo}" + 
                    "\n ve a recogerlo a su casa";
                return mensaje;
            }
            else
            {
                string mensajeDos = "Aún sirve mi compu";
                return mensajeDos;
                    
            }
        }

        public  string PintarBicicleta()
        {
            string mensajeDos = $"también debo pintar mi bicicleta de color {Mibici.Color} ";
            return mensajeDos;
        }

       public string Escribir()
       {
           string mensajeTres = $"Voy apuntar mis notas en este cuaderno nuevo {MiCuaderno.Tamaño}";
            return mensajeTres;
       }

        string nombreVendedor = "Oscarito";
        public string Vender()
        {
            string mensajeCuatro = $"vendo cuadernos {MiCuaderno.Tamaño} de {MiCuaderno.NumeroHojas} hojas a un precio de {MiCuaderno.Precio} dólar. att:  {nombreVendedor}";
            return mensajeCuatro;
        }
    }
}

