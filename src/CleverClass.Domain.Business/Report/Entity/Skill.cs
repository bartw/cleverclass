using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report.Entity
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        
        public virtual Course Course { get; set; }
        public virtual IEnumerable<Test> Tests { get; set; }
    }
}
