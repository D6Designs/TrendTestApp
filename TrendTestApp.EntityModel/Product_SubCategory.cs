//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrendTestApp.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_SubCategory
    {
        public int Product_SubCategoryID { get; set; }
        public int ProductID { get; set; }
        public int SubCategoryID { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<System.DateTime> ActiveFrom { get; set; }
        public Nullable<System.DateTime> ActiveTo { get; set; }
        public Nullable<bool> Valid { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
