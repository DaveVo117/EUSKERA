﻿using EUSKERA.Entity;

namespace EUSKERA.AplicacionWeb.Models.ViewModels
{
    public class VMTipoDocumentoVenta
    {

        //public TipoDocumentoVenta()
        //{
        //    Venta = new HashSet<Venta>();
        //}

        public int IdTipoDocumentoVenta { get; set; }
        public string? TxtDescripcion { get; set; }
        public bool? SnActivo { get; set; }
        //public DateTime? FechaRegistro { get; set; }

        //public virtual ICollection<Venta> Venta { get; set; }

    }
}
