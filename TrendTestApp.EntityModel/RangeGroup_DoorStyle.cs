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
    
    public partial class RangeGroup_DoorStyle
    {
        public int RangeGroup_DoorStyle_Id { get; set; }
        public int RangeGroupId { get; set; }
        public int DoorStyleId { get; set; }
        public int ListOrder { get; set; }
        public Nullable<System.DateTime> ActiveFrom { get; set; }
        public Nullable<System.DateTime> ActiveTo { get; set; }
    
        public virtual DoorStyle DoorStyle { get; set; }
        public virtual RangeGroup RangeGroup { get; set; }
    }
}
