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
    
    public partial class CompanyBranding
    {
        public int CompanyBrandingId { get; set; }
        public int CompanyId { get; set; }
        public string PrimaryBrandColour { get; set; }
        public byte[] CompanyLogo { get; set; }
        public bool HasImage { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
