//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarDrobe_M_V_C.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sho
    {
        public int ShoeID { get; set; }
        public string ShoeName { get; set; }
        public string Photo { get; set; }
        public int TypeID { get; set; }
        public string Color { get; set; }
        public int SeasonID { get; set; }
        public string Occasion { get; set; }
    
        public virtual Season Season { get; set; }
        public virtual Type Type { get; set; }
    }
}
