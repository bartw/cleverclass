using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual ClassGroup ClassGroup { get; set; }
        public virtual IEnumerable<TestScore> TestScores { get; set; }
    }
}
