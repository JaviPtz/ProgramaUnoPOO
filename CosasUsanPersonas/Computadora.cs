using System;

namespace CosasUsanPersonas
{
    class Computadora
    {
        public string Pantalla { get; set; }
        public string Procesador { get; set; }

        public string TarjetaRAM { get; set; }

        public string DiscoDuro { get; set; }

        public string TarjetVideo { get; set; }

        public bool Estado  { get; set; }

        public string Investigar()
        {
            string mensajeUno = "Vamos a internet a investigar cosas divetidas";
            return mensajeUno;
        }
        public string Jugar() 
        {
            string mensajeDos = "Juega en linea o descarga juegos";
            return mensajeDos;
        }
        public string CrearProgramas()
        {
            string mensajeTres = "Vamos a programar";
            return mensajeTres;
        }
        public string InstalarProgramas()
        {
            string mensajeCuatro = "Instalaste visual estudio";
            return mensajeCuatro;
        }
        public Persona PropietarioComputadora { get; set; }

    }
}
