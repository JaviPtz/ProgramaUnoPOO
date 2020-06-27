using System;


namespace CosasUsanPersonas
{
    class Cocina
    {
        //atributos
        public string Marca { get; set; }

        public string Tamaño { get; set; }

        public int NumeroOrnillas { get; set; }

        public string Tipo { get; set; }

        public Boolean Estado { get; set; }


        //Métodos

        public string Calentar()
        {
            if(Estado == true)
            {
                string mensaje = $"tiene {NumeroOrnillas} ornillas encendidas ";
                return mensaje;
            }
            else
            {
                string mensajedos = "ahora cómo cocino";
                return mensajedos;
            }
        }

        public string Cocinar()
        {
            string mensajeTres = "sirvo para cocinar";
            return mensajeTres;
        }

        public string hervir()
        {
            string mensajeCuatro = "Puede hervir agua con migo";
            return mensajeCuatro;
        }

        public string Hornear()
        {
            string mensajeCinco = "Tambien puedo hornear pasteles o azarlas";
            return mensajeCinco;
        }

        public Persona PropietarioCocina { get; set; }





    }
}
