//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrMinaClinic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PregnancyDetail
    {
        public int Id { get; set; }
        public int PregnancyId { get; set; }
        public bool Living { get; set; }
        public string AF { get; set; }
        public bool Sex { get; set; }
        public string Placenta { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Presentation { get; set; }
        public string Other { get; set; }
    
        public virtual Pregnancy Pregnancy { get; set; }
    }
}
