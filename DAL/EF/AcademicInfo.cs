//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class AcademicInfo
    {
        public int RId { get; set; }
        public string JSC { get; set; }
        public string JSC_reg { get; set; }
        public string SSC { get; set; }
        public string SSC_reg { get; set; }
        public string HSC { get; set; }
        public string HSC_reg { get; set; }
        public Nullable<int> FK_NID { get; set; }
    
        public virtual UsersDetail UsersDetail { get; set; }
    }
}
