using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatTipoMovimiento
    {
        public CatTipoMovimiento()
        {
            CtrlMovimientos = new HashSet<CtrlMovimiento>();
        }

        public int IdTipoMovimiento { get; set; }
        public string? TxtNombre { get; set; }

        public virtual ICollection<CtrlMovimiento> CtrlMovimientos { get; set; }
    }
}
