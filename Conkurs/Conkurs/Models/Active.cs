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
    
    public partial class Active
    {
        public int Id_ak { get; set; }
        public string Name_meropr { get; set; }
        public string Date_n { get; set; }
        public Nullable<int> Dni { get; set; }
        public string Name_active { get; set; }
        public System.TimeSpan Time { get; set; }
        public Nullable<int> Moderator_id { get; set; }
        public Nullable<int> jury_id1 { get; set; }
        public Nullable<int> jury_id2 { get; set; }
        public Nullable<int> jury_id3 { get; set; }
        public Nullable<int> jury_id4 { get; set; }
        public Nullable<int> jury_id5 { get; set; }
        public Nullable<int> id_pobed { get; set; }
    
        public virtual Jury Jury { get; set; }
        public virtual Jury Jury1 { get; set; }
        public virtual Jury Jury2 { get; set; }
        public virtual Jury Jury3 { get; set; }
        public virtual Jury Jury4 { get; set; }
        public virtual Members Members { get; set; }
        public virtual Moderator Moderator { get; set; }
    }
}