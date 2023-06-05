using System;
using System.Collections.Generic;

namespace EUSKERA.Entity
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProducto { get; set; }
        public string? TxtCodigoBarra { get; set; }
        public string? TxtMarca { get; set; }
        public string? TxtDescripcion { get; set; }
        public int? IdCategoria { get; set; }
        public int? Stock { get; set; }
        public string? TxtUrlImagen { get; set; }
        public string? TxtNombreImagen { get; set; }
        public decimal? Precio { get; set; }
        public bool? SnActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdNegocio { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual Negocio? IdNegocioNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
