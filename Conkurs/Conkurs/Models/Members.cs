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
    
    public partial class Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Members()
        {
            this.Active = new HashSet<Active>();
        }
    
        public int Id_Members { get; set; }
        public string FIO { get; set; }
        public string Gmail { get; set; }
        public Nullable<System.DateTime> Date_r { get; set; }
        public Nullable<int> id_code1 { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string Pol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active> Active { get; set; }
        public virtual Country Country { get; set; }
    }
}