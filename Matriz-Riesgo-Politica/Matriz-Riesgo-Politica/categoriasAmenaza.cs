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
    
    public partial class categoriasAmenaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoriasAmenaza()
        {
            this.enunciadoPoliticaAmenazas = new HashSet<enunciadoPoliticaAmenaza>();
            this.AccionRiesgoes = new HashSet<AccionRiesgo>();
            this.detalleAnalisisRiesgoes = new HashSet<detalleAnalisisRiesgo>();
        }
    
        public int codigoCategoria { get; set; }
        public string nombreCategoriaRiesgo { get; set; }
        public string descripcionCategoriaRiesgo { get; set; }
        public string tipoCreacionAmenaza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enunciadoPoliticaAmenaza> enunciadoPoliticaAmenazas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccionRiesgo> AccionRiesgoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleAnalisisRiesgo> detalleAnalisisRiesgoes { get; set; }
    }
}
