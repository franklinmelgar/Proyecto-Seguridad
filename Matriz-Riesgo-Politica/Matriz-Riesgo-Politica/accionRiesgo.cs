//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matriz_Riesgo_Politica
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccionRiesgo
    {
        public int codigoAccion { get; set; }
        public Nullable<int> codigoCategoria { get; set; }
        public Nullable<int> nivelRiesgoMinimo { get; set; }
        public Nullable<int> nivelRiesgoMayor { get; set; }
        public string descripcionAccion { get; set; }
        public Nullable<int> codigoAccionRiesgo { get; set; }
    
        public virtual categoriasAmenaza categoriasAmenaza { get; set; }
        public virtual configuracionRiesgo configuracionRiesgo { get; set; }
    }
}
