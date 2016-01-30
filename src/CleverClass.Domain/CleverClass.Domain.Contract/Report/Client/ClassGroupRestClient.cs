using CleverClass.Domain.Contract.Report.Interface;
using CleverClass.Domain.Contract.Report.Dto;
using System;
using System.Collections.Generic;

namespace CleverClass.Domain.Rest
{
    public class ClassGroupRestClient : IClassGroupFacade
    {
        public IEnumerable<ClassGroupDto> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public ClassGroupDto Get(int id)
        {
            throw new NotImplementedException();
        }
        
        public ClassGroupDto Create(ClassGroupDto classGroup)
        {
            throw new NotImplementedException();
        }
        
        public ClassGroupDto Update(ClassGroupDto classGroup)
        {
            throw new NotImplementedException();
        }
        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}