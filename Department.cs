//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OurWebsite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Class = new HashSet<Class>();
        }
    
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyID { get; set; }
    
        public virtual ICollection<Class> Class { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}