//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Collections.Generic;
    
    public partial class OUVRAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OUVRAGE()
        {
            this.STOCKER = new HashSet<STOCKER>();
            this.TARIFER = new HashSet<TARIFER>();
            this.ECRIVAIN = new HashSet<ECRIVAIN>();
        }
    
        public int NUMOUVR { get; set; }
        public string NOMOUVR { get; set; }
        public Nullable<short> ANNEEPARU { get; set; }
        public Nullable<int> NUMRUB { get; set; }
        public string NOMED { get; set; }
    
     public virtual CLASSIFICATION CLASSIFICATION { get; set; }
     public virtual EDITEUR EDITEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKER> STOCKER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARIFER> TARIFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECRIVAIN> ECRIVAIN { get; set; }
    }
}
