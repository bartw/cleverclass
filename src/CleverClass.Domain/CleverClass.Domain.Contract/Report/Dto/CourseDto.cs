using System.Collections.Generic;

namespace CleverClass.Domain.Contract.Report.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IEnumerable<ClassGroupDto> ClassGroups { get; set; }
        public IEnumerable<SkillDto> Skills { get; set; }
    }
}
