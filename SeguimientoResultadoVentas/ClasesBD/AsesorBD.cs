using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.ClasesBD
{
    [ActiveRecord("asesores", Lazy = false)]
    public class AsesorBD : ActiveRecordBase<AsesorBD>
    {
        #region Variables privadas
        private int id;
        private int numero_empleado;
        private string nombre;
        private SeccionBD seccion_id;
        private int status;


        #endregion

        #region Variables encapsuladas

        [PrimaryKey("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property("numero_empleado")]
        public virtual int Numero_empleado
        {
            get { return numero_empleado; }
            set { numero_empleado = value; }
        }

        [Property("nombre")]
        public virtual string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [BelongsTo("seccion_id")]
        public virtual SeccionBD Seccion_id
        {
            get { return seccion_id; }
            set { seccion_id = value; }
        }

        [Property("status")]
        public virtual int Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}
