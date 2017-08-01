using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.Clases
{
    public class Usuario
    {
        #region Variables privadas

        private int id;
        private string nombre;
        private string clave;
        private int status;
        private DateTime registrado;

        #endregion

        #region Variables encapsuladas "solo lectura"

        public int Id
        {
            get { return id; }
        }


        public string Nombre
        {
            get { return nombre; }
        }


        public string Clave
        {
            get { return clave; }
        }


        public int Status
        {
            get { return status; }
        }


        public DateTime Registrado
        {
            get { return registrado; }
        }
        #endregion
    }
}
