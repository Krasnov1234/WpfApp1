//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class InsRoleTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsRoleTB()
        {
            this.InsSolderTBs = new HashSet<InsSolderTB>();
            this.InsSpisokTBs = new HashSet<InsSpisokTB>();
        }
    
        public int Id { get; set; }
        public string Роли { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsSolderTB> InsSolderTBs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsSpisokTB> InsSpisokTBs { get; set; }
    }
}
