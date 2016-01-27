using CleverClass.Domain.Contract.Report.Interface;
using CleverClass.Domain.Contract.Report.Dto;
using CleverClass.Domain.Business.Report.Entity;
using System.Collections.Generic;

namespace CleverClass.Domain.Business.Report
{
    public class ClassGroupFacade : IClassGroupFacade
    {
        public IEnumerable<ClassGroupDto> GetAll()
        {
            return new List<ClassGroupDto>();
        }
        
        public ClassGroupDto Get(int id)
        {
            return new ClassGroupDto();
        }
        
        public ClassGroupDto Create(ClassGroupDto classGroup)
        {
            return new ClassGroupDto();
        }
        
        public ClassGroupDto Update(ClassGroupDto classGroup)
        {
            return new ClassGroupDto();
        }
        
        public void Delete(int id)
        {
            
        }
    }
}