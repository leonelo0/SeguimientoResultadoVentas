using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.ClasesBD
{
    [ActiveRecord("secciones", Lazy = false)]
    public class SeccionBD : ActiveRecordBase<SeccionBD>
    {
        #region Variables privadas

        private int id;
        private string nombre;
        private string estado;
        private string fondo;

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

        [Property("estado")]
        public virtual string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [Property("fondo")]
        public virtual string Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }

        #endregion
    }
}
