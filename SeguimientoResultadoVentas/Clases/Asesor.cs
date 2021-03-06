﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoResultadoVentas.Clases
{
    public class Asesor
    {
        #region Variables privadas
        private int id;
        private int numero_empleado;
        private string nombre;
        private Seccion seccion_id;
        private int status;
        #endregion

        #region Variables encapsuladas "solo lectura"
        public int Id
        {
            get { return id; }
        }


        public int Numero_empleado
        {
            get { return numero_empleado; }
        }


        public string Nombre
        {
            get { return nombre; }
        }


        public Seccion Seccion_id
        {
            get { return seccion_id; }
        }


        public int Status
        {
            get { return status; }
        }
        #endregion

    }
}
