//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIB_Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class microPosition2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public microPosition2()
        {
            this.choixMicroes = new HashSet<choixMicro>();
        }
    
        public int idMicro2 { get; set; }
        public string nomMicroCentre { get; set; }
        public int idMatériel_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<choixMicro> choixMicroes { get; set; }
        public virtual Materiel Materiel { get; set; }
    }
}
