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
    
    public partial class RangeGroup_Tags
    {
        public int RangeGroupTagId { get; set; }
        public int RangeGroupId { get; set; }
        public int TagId { get; set; }
    
        public virtual RangeGroup RangeGroup { get; set; }
        public virtual Tag Tag { get; set; }
    }
}