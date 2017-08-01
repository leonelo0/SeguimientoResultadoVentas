using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.Clases
{
    public class PlanVentaDetalle
    {
        #region Variables privadas
      
        private int id;
        private PlanVentaAnual plan_venta_anual_id;
        private Asesor asesor_id;
        private int tipo_plan;
        private Usuario usuario_id;
        private DateTime registrado = new DateTime(1900,1,1);
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

        #region Variables encapsuladas "solo lectura"
       
        
        public int Id
        {
            get { return id; }
        }


        public PlanVentaAnual Plan_venta_anual_id
        {
            get { return plan_venta_anual_id; }
        }


        public Asesor Asesor_id
        {
            get { return asesor_id; }
        }


        public int Tipo_plan
        {
            get { return tipo_plan; }
        }


        public Usuario Usuario_id
        {
            get { return usuario_id; }
        }


        public DateTime Registrado
        {
            get { return registrado; }
        }


        public decimal Enero
        {
            get { return enero; }
        }


        public decimal Febrero
        {
            get { return febrero; }
        }


        public decimal Marzo
        {
            get { return marzo; }
        }


        public decimal Abril
        {
            get { return abril; }
        }


        public decimal Mayo
        {
            get { return mayo; }
        }


        public decimal Junio
        {
            get { return junio; }
        }


        public decimal Julio
        {
            get { return julio; }
        }


        public decimal Agosto
        {
            get { return agosto; }
        }


        public decimal Septiembre
        {
            get { return septiembre; }
        }


        public decimal Octubre
        {
            get { return octubre; }
        }


        public decimal Noviembre
        {
            get { return noviembre; }
        }


        public decimal Diciembre
        {
            get { return diciembre; }
        }
       
        
        #endregion
    }
}

