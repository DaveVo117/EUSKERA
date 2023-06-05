using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatCliente
    {
        public CatCliente()
        {
            CtrlMovimientos = new HashSet<CtrlMovimiento>();
        }

        public int IdCliente { get; set; }
        public int? IdGiro { get; set; }
        public string? TxtRazonSocial { get; set; }
        public string? Rfc { get; set; }
        public string? Calle { get; set; }
        public int? NumExterior { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public int? Cp { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? SnActivo { get; set; }

        public virtual ICollection<CtrlMovimiento> CtrlMovimientos { get; set; }
    }
}
