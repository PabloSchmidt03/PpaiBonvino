﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bodega
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string historia { get; set; }
        public string coordenadasUbicacion { get; set; }
        public DateTime fechaUltimaActualizacion { get; set; }
        public int periodoActualizacion { get; set; } //en dias

        public List<Vino> listaVinos = new List<Vino>(); 

    }
}
