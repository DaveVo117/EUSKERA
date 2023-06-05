using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CtrlMovimiento
    {
        public int IdMovimiento { get; set; }
        public int? IdNaturaleza { get; set; }
        public int? IdTipoMovimiento { get; set; }
        public int? IdServicio { get; set; }
        public string? CtaBancaria { get; set; }
        public decimal? Monto { get; set; }
        public decimal? PorcentajeImpuesto { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdEstatus { get; set; }

        public virtual CatCliente? IdClienteNavigation { get; set; }
        public virtual CatEstatusMovimiento? IdEstatusNavigation { get; set; }
        public virtual CatNaturalezaMovimiento? IdNaturalezaNavigation { get; set; }
        public virtual CatProveedor? IdProveedorNavigation { get; set; }
        public virtual CatServicio? IdServicioNavigation { get; set; }
        public virtual CatTipoMovimiento? IdTipoMovimientoNavigation { get; set; }
    }
}
