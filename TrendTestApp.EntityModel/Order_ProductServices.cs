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
    
    public partial class Order_ProductServices
    {
        public int Order_ProductServiceId { get; set; }
        public int ProductServiceId { get; set; }
        public int OrderId { get; set; }
        public Nullable<decimal> NetCostPrice { get; set; }
        public Nullable<decimal> DiscountRate { get; set; }
        public Nullable<decimal> TotalCostPrice { get; set; }
        public Nullable<decimal> MarkUpPercent { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public Nullable<int> ListOrder { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Notes { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ProductService ProductService { get; set; }
    }
}
