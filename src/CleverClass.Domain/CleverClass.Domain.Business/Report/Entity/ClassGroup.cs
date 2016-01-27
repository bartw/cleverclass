using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report.Entity
{
    public class ClassGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual IEnumerable<Course> Courses { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
    }
}
