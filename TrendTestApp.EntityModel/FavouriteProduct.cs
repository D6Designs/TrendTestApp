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
    
    public partial class FavouriteProduct
    {
        public int FavouriteId { get; set; }
        public int CompanyId { get; set; }
        public int CatalogueId { get; set; }
        public int ProductId { get; set; }
    
        public virtual Catalogue Catalogue { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
    }
}