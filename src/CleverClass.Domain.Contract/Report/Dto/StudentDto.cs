using System.Collections.Generic;

namespace CleverClass.Domain.Contract.Report.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ClassGroupDto ClassGroup { get; set; }
        public IEnumerable<TestScoreDto> TestScores { get; set; }
    }
}
