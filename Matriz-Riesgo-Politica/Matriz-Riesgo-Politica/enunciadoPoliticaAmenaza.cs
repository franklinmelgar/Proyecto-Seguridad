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
    
    public partial class enunciadoPoliticaAmenaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enunciadoPoliticaAmenaza()
        {
            this.seccionPoliticaAmenazas = new HashSet<seccionPoliticaAmenaza>();
        }
    
        public int codigoEnunciadoPolitica { get; set; }
        public int codigoCategoria { get; set; }
        public string descripcionEnunciado { get; set; }
    
        public virtual categoriasAmenaza categoriasAmenaza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seccionPoliticaAmenaza> seccionPoliticaAmenazas { get; set; }
    }
}
