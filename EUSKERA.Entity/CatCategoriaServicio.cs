using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatCategoriaServicio
    {
        public CatCategoriaServicio()
        {
            CatServicios = new HashSet<CatServicio>();
        }

        public int IdCategoriaServicio { get; set; }
        public string? TxtNombre { get; set; }
        public string? TxtDescripcion { get; set; }
        public bool? SnActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<CatServicio> CatServicios { get; set; }
    }
}
