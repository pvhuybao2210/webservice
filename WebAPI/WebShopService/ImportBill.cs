//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShopService
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImportBill
    {
        public int id { get; set; }
        public string code { get; set; }
        public string agencyName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> total { get; set; }
    }
}
