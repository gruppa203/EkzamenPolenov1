//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkzamenPolenov1.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID { get; set; }
        public string Фамилия { get; set; }
        public string Имя__отчество { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Role { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
