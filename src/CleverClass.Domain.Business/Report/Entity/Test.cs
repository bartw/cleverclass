using System;
using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report.Entity
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int MaximumScore { get; set; }
        public int Weight { get; set; }
        
        public virtual Skill Skill { get; set; }
        public virtual IEnumerable<TestScore> TestScores { get; set; }
    }
}
