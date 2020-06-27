using System;
using System.Net.Http.Headers;

namespace CosasUsanPersonas
{
    class Cuaderno
    {

        public string Forma { get; set; }

        public string Tamaño { get; set; }

        public string Tipo { get; set; }

        public int NumeroHojas { get; set; }

        public int Precio { get; set; }

        public string dibujar()
        {

            string mensajeUno = "soy un dibujito";
            return mensajeUno;
        }


        public string escribir()
        {
            string mensajeDos = "Escribe todo lo que puedas";
            return mensajeDos;
        }

        public string Tomarnotas()
        {
            string mensajeTres= "Escribsite aqui puntos importantes de la clase";
            return mensajeTres;
        }

        public string hacerTareas()
        {
            string mensajeCuatro = "Presenta tu tarea con migo";
            return mensajeCuatro;
        }


        public Persona  CuadernoPersonal { get; set; }

    }
}
