using System;


namespace BiblioPersonas
{
    public class Persona
    {
        //Comentario
        #region Atributos
        private string nombre;
        private string telefono;
        private byte edad;
        private string direccion;

   


        #endregion

        #region Propiedades
        public string Nombre { get => nombre; 
            set
            {
                if (value == "")
                {
                    nombre = "Anónimo";
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        #endregion

        #region Constructor
        public Persona(string nombre, string telefono, byte edad, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Edad = edad;
            Direccion = direccion;
        }
        #endregion



    }
}
