﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdmEdificios.Datos;

namespace AdmEdificios.Negocio
{
    public class BarrioServicio
    {

        BarrioDatos bd = new BarrioDatos();

        // VA A BUSCAR TODOS LOS BARRIOS DE CABA A BarriosDatos
        public List<BarriosCABA> ListarBarrios()
        {
            return bd.ListarBarrios();
        }
    }
}