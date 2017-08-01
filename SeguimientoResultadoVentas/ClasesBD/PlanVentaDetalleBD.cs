using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.ClasesBD
{
    [ActiveRecord("plan_venta_detalles", Lazy = false)]
    public class PlanVentaDetalleBD : ActiveRecordBase<PlanVentaDetalleBD>
    {
        #region Variables privadas

        private int id;
        private PlanVentaAnualBD plan_venta_anual_id;
        private AsesorBD asesor_id;
        private string tipo_plan;
        private UsuarioBD usuario_id;
        private DateTime registrado = new DateTime(1900, 1, 1);
        private decimal enero;
        private decimal febrero;
        private decimal marzo;
        private decimal abril;
        private decimal mayo;
        private decimal junio;
        private decimal julio;
        private decimal agosto;
        private decimal septiembre;
        private decimal octubre;
        private decimal noviembre;
        private decimal diciembre;

        #endregion

        #region Variables encapsuladas

        [PrimaryKey("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        
        [BelongsTo("plan_venta_anual_id")]
        public virtual PlanVentaAnualBD Plan_venta_anual_id
        {
            get { return plan_venta_anual_id; }
            set { plan_venta_anual_id = value; }
        }
       
 
        [BelongsTo("asesor_id")]
        public virtual AsesorBD Asesor_id
        {
            get { return asesor_id; }
            set { asesor_id = value; }
        }
        
        
        [Property("tipo_plan")]
        public virtual string Tipo_plan
        {
            get { return tipo_plan; }
            set { tipo_plan = value; }
        }
       
        
        [BelongsTo("usuario_id")]
        public virtual UsuarioBD Usuario_id
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
       
        
        [Property("enero")]
        public virtual decimal Enero
        {
            get { return enero; }
            set { enero = value; }
        }
        
        
        [Property("enero")]
        public virtual DateTime Registrado
        {
            get { return registrado; }
            set { registrado = value; }
        }
        
        
        [Property("febrero")]
        public virtual decimal Febrero
        {
            get { return febrero; }
            set { febrero = value; }
        }
       
        
        [Property("marzo")]
        public virtual decimal Marzo
        {
            get { return marzo; }
            set { marzo = value; }
        }
       
        
        [Property("abril")]
        public virtual decimal Abril
        {
            get { return abril; }
            set { abril = value; }
        }
       
        
        [Property("mayo")]
        public virtual decimal Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        
        
        [Property("junio")]
        public virtual decimal Junio
        {
            get { return junio; }
            set { junio = value; }
        }
      
        
        [Property("agosto")]
        public virtual decimal Agosto
        {
            get { return agosto; }
            set { agosto = value; }
        }
       
        
        [Property("septiembre")]
        public virtual decimal Septiembre
        {
            get { return septiembre; }
            set { septiembre = value; }
        }
        
        
        [Property("octubre")]
        public virtual decimal Octubre
        {
            get { return octubre; }
            set { octubre = value; }
        }
        
        
        [Property("noviembre")]
        public virtual decimal Noviembre
        {
            get { return noviembre; }
            set { noviembre = value; }
        }
       
        
        [Property("diciembre")]
        public virtual decimal Diciembre
        {
            get { return diciembre; }
            set { diciembre = value; }
        }

        #endregion
    }
}
