//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hackothon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSiparis
    {
        public int faturaKod { get; set; }
        public Nullable<int> kullaniciKod { get; set; }
        public string faturaAdres { get; set; }
        public Nullable<int> siparisDurumKod { get; set; }
        public System.DateTime siparisTarih { get; set; }
    
        public virtual tblSiparisDurum tblSiparisDurum { get; set; }
    }
}
