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
    
    public partial class ColourImage
    {
        public int ColourImageID { get; set; }
        public byte[] Image { get; set; }
        public int ColourID { get; set; }
    
        public virtual Colour Colour { get; set; }
    }
}