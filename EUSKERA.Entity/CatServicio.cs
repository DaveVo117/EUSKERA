using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatServicio
    {
        public CatServicio()
        {
            CtrlMovimientos = new HashSet<CtrlMovimiento>();
        }

        public int IdServicio { get; set; }
        public string? TxtNombre { get; set; }
        public string? TxtDescripcion { get; set; }
        public int? IdCategoriaServicio { get; set; }
        public int? IdNegocio { get; set; }
        public bool? SnActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual CatCategoriaServicio? IdCategoriaServicioNavigation { get; set; }
        public virtual Negocio? IdNegocioNavigation { get; set; }
        public virtual ICollection<CtrlMovimiento> CtrlMovimientos { get; set; }
    }
}
