using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual IEnumerable<ClassGroup> ClassGroups { get; set; }
        public virtual IEnumerable<Skill> Skills { get; set; }
    }
}
