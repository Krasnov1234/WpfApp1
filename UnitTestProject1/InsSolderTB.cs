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
    
    public partial class InsSolderTB
    {
        public int Id { get; set; }
        public string ФИО { get; set; }
        public int Id_Звание { get; set; }
        public int Id_Рата { get; set; }
    
        public virtual InsRoleTB InsRoleTB { get; set; }
        public virtual InsZvanieTB InsZvanieTB { get; set; }
    }
}