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
    
    public partial class TeacherCourse
    {
        public int TeacherCourseID { get; set; }
        public string TeacherID { get; set; }
        public int CourseID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}