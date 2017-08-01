using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.ClasesBD
{
    [ActiveRecord("usuarios", Lazy = false)]
    public class UsuarioBD : ActiveRecordBase<UsuarioBD>
    {
        #region Variables privadas

        private int id;
        private string nombre;
        private string clave;
        private int status;
        private DateTime registrado;

        #endregion

        #region Variables encapsuladas

        [PrimaryKey("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        [Property("nombre")]
        public virtual string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        [Property("clave")]
        public virtual string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
       
        [Property("status")]
        public virtual int Status
        {
            get { return status; }
            set { status = value; }
        }
       
        [Property("registrado")]
        public virtual DateTime Registrado
        {
            get { return registrado; }
            set { registrado = value; }
        }

        #endregion

    }
}
