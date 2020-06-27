using System;


namespace CosasUsanPersonas
{
    class Bicicleta
    {
        public string Tamaño { get; set; }

        public string Color { get; set; }

        public string Tipo { get; set; }

        public string Material { get; set; }

        public string Estado { get; set; }

        public string Transportar()
        {
            string mensaje = $"El sábado necesitare mi bicicleta {Tipo} {Tamaño} para transportarme";
            return mensaje;
        }

        public string HacerEjercicio()
        {
            string mensajeDos = "vamos a perder unos kilitos de más";
            return mensajeDos;
        }

        public string aumentarRecistenciaFisica()
        {
            string mensajeTres = "vamos si se puede";
            return mensajeTres;
        }

        public string Montar()
        {
            string mensajeCuatro = "Montame y visitemos nuevos sitios de tu sector";
            return mensajeCuatro;
        }

        public Persona Propietario { get; set; }
    }
}