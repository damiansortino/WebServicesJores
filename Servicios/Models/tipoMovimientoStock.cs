//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipoMovimientoStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipoMovimientoStock()
        {
            this.movimientoStock = new HashSet<movimientoStock>();
        }
    
        public int TipoMovimientoStockId { get; set; }
        public string nombreTipoMovimientoStock { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimientoStock> movimientoStock { get; set; }
    }
}