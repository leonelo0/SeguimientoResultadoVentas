using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.ClasesBD
{
    [ActiveRecord("plan_venta_anual", Lazy = false)]
    public class PlanVentaAnualBD : ActiveRecordBase<PlanVentaAnualBD>
    {
        #region Variables privadas

        private int id;
        private SeccionBD seccion_id;
        private int anio;
        private int total_de_modulos;
        private int tipo_plan;
        private decimal prima_promedio;
        private DateTime registrado = new DateTime(1900, 1, 1);
        private UsuarioBD usuario_id;

        #endregion

        #region Variables encapsuladas

        [PrimaryKey("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
        [BelongsTo("seccion_id")]
        public virtual SeccionBD Seccion_id
        {
            get { return seccion_id; }
            set { seccion_id = value; }
        }
        
        [Property("anio")]
        public virtual int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
      
        [Property("total_de_modulos")]
        public virtual int Total_de_modulos
        {
            get { return total_de_modulos; }
            set { total_de_modulos = value; }
        }
     
        [Property("tipo_plan")]
        public virtual int Tipo_plan
        {
            get { return tipo_plan; }
            set { tipo_plan = value; }
        }

        [Property("prima_promedio")]
        public virtual decimal Prima_promedio
        {
            get { return prima_promedio; }
            set { prima_promedio = value; }
        }

        [Property("registrado")]
        public virtual DateTime Registrado
        {
            get { return registrado; }
            set { registrado = value; }
        }

        [BelongsTo("Usuario_id")]
        public virtual UsuarioBD Usuario_id
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }

        #endregion
    }
}
