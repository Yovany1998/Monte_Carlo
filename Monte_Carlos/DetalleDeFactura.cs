//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monte_Carlos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleDeFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdMenu { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Menu Menu { get; set; }
    }
}