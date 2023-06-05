using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class CatNaturalezaMovimiento
    {
        public CatNaturalezaMovimiento()
        {
            CtrlMovimientos = new HashSet<CtrlMovimiento>();
        }

        public int Id { get; set; }
        public string? TxtNombre { get; set; }

        public virtual ICollection<CtrlMovimiento> CtrlMovimientos { get; set; }
    }
}
