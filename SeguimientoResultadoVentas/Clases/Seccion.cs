using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.Clases
{
    public class Seccion
    {
        #region Variables privadas
        private int id;
        private string nombre;
        private string estado;
        private string fondo;
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

        public string Fondo
        {
            get { return fondo; }
        }
        

        public string Estado
        {
            get { return estado; }
        }
        #endregion
    
    }
}
