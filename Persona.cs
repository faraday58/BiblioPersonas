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
        //Manejo de arrow functions y operador ternario
        //Simplifica la expresión utilizada en Nombre
        // También podemos decir que se trata de una refactorización
        public string Telefono { get => telefono;
            set => telefono = value == "" ? "56581111": value ; 
        }
        public byte Edad { get => edad;
            set => edad = value < 13 || value > 100  ? (byte)18 : value; 
        }
        public string Direccion { get => direccion; 
            set => direccion =  value == ""? "CDMX": value ; 
        }

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
