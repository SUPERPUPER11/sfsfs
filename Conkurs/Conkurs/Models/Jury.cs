//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conkurs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jury
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jury()
        {
            this.Active = new HashSet<Active>();
            this.Active1 = new HashSet<Active>();
            this.Active2 = new HashSet<Active>();
            this.Active3 = new HashSet<Active>();
            this.Active4 = new HashSet<Active>();
        }
    
        public int Id_jury { get; set; }
        public string FIO { get; set; }
        public string Pol { get; set; }
        public string Gmail { get; set; }
        public Nullable<System.DateTime> Date_r { get; set; }
        public int id_code1 { get; set; }
        public string Number { get; set; }
        public Nullable<int> Napr_id { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active4 { get; set; }
        public virtual Country Country { get; set; }
    }
}
