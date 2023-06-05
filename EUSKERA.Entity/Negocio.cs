using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class Negocio
    {
        public Negocio()
        {
            CatServicio = new HashSet<CatServicio>();
            Producto = new HashSet<Producto>();
        }

        public int IdNegocio { get; set; }
        public string? TxtUrlLogo { get; set; }
        public string? TxtNombreLogo { get; set; }
        public string? TxtNumeroDocumento { get; set; }
        public string? TxtNombre { get; set; }
        public string? TxtCorreo { get; set; }
        public string? TxtDireccion { get; set; }
        public string? TxtTelefono { get; set; }
        public decimal? PorcentajeImpuesto { get; set; }
        public string? TxtSimboloMoneda { get; set; }

        public virtual ICollection<CatServicio> CatServicio { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
