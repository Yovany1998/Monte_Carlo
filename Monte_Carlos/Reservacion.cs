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
    
    public partial class Reservacion
    {
        public int IdReservacion { get; set; }
        public int IdCliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Mesa { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
