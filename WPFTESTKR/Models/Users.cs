//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFTESTKR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int UserID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int EmployeesID { get; set; }
        public int PositionID { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Position Position { get; set; }
    }
}
