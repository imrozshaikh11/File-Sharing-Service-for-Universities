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
    
    public partial class Course
    {
        public Course()
        {
            this.TeacherCourse = new HashSet<TeacherCourse>();
            this.UserFile = new HashSet<UserFile>();
        }
    
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int ClassID { get; set; }
    
        public virtual CourseClass CourseClass { get; set; }
        public virtual ICollection<TeacherCourse> TeacherCourse { get; set; }
        public virtual ICollection<UserFile> UserFile { get; set; }
        public virtual Class Class { get; set; }
    }
}
