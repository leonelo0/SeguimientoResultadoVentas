using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.Clases
{
    public class PlanVentaAnual
    {
        #region Variables privadas
       
        private int id;
        private Seccion seccion_id;
        private int anio;
        private int total_de_modulos;
        private int tipo_plan;
        private decimal prima_promedio;
        private DateTime registrado = new DateTime(1900,1,1);
        private Usuario usuario_id;
        
        #endregion

        #region Variables encapsuladas "solo lectura"
      
        public int Id
        {
            get { return id; }
        }


        public Seccion Seccion_id
        {
            get { return seccion_id; }
        }


        public int Anio
        {
            get { return anio; }
        }
        
        
        public int Total_de_modulos
        {
            get { return total_de_modulos; }
        }
        
        
        public int Tipo_plan
        {
            get { return tipo_plan; }
        }
        
        
        public decimal Prima_promedio
        {
            get { return prima_promedio; }
        }
        
        
        public DateTime Registrado
        {
            get { return registrado; }
        }
        
        
        public Usuario Usuario_id
        {
            get { return usuario_id; }
        }
       
        #endregion
    }
}
