using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatEstatusMovimiento
    {
        public CatEstatusMovimiento()
        {
            CtrlMovimientos = new HashSet<CtrlMovimiento>();
        }

        public int IdEstatusMovimiento { get; set; }
        public string? TxtNombre { get; set; }
        public string? TxtDescripcion { get; set; }
        public int? IdNaturaleza { get; set; }

        public virtual ICollection<CtrlMovimiento> CtrlMovimientos { get; set; }
    }
}
