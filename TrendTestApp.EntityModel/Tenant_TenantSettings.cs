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
    
    public partial class Tenant_TenantSettings
    {
        public int Tenant_TenantSettingId { get; set; }
        public int TenantId { get; set; }
        public int TenantSettingId { get; set; }
        public string Value { get; set; }
    
        public virtual Tenant Tenant { get; set; }
        public virtual TenantSetting TenantSetting { get; set; }
    }
}
