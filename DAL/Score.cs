//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int id { get; set; }
        public Nullable<double> listening_score { get; set; }
        public Nullable<double> reading_score { get; set; }
        public Nullable<double> speaking_score { get; set; }
        public Nullable<double> writing_score { get; set; }
        public Nullable<int> student_id { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
