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
    
    public partial class Token
    {
        public int Id { get; set; }
        public string Tkey { get; set; }
        public Nullable<System.DateTime> StartingTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Username { get; set; }
    }
}
