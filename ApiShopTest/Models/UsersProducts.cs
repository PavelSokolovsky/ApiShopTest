//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiShopTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersProducts
    {
        public int id { get; set; }
        public int idUsers { get; set; }
        public int idProducts { get; set; }
        public int amountMAX { get; set; }
        public int amountCurrent { get; set; }
        public int amountMin { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Users Users { get; set; }
    }
}
