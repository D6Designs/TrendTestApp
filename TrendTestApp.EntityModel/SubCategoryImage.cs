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
    
    public partial class SubCategoryImage
    {
        public int SubCategoryImageId { get; set; }
        public byte[] Image { get; set; }
        public int SubCategoryId { get; set; }
    
        public virtual SubCategory SubCategory { get; set; }
    }
}
