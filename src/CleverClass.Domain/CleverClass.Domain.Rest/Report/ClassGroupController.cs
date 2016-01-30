using CleverClass.Domain.Contract.Report.Interface;
using CleverClass.Domain.Contract.Report.Dto;
using CleverClass.Domain.Business.Report;
using System.Collections.Generic;

namespace CleverClass.Domain.Rest
{
    public class ClassGroupController : IClassGroupFacade
    {
        private readonly IClassGroupFacade _classGroupFacade;
        
        public ClassGroupController()
        {
            _classGroupFacade = new ClassGroupFacade();
        }
        
        public IEnumerable<ClassGroupDto> GetAll()
        {
            return _classGroupFacade.GetAll();
        }
        
        public ClassGroupDto Get(int id)
        {
            return _classGroupFacade.Get(id);
        }
        
        public ClassGroupDto Create(ClassGroupDto classGroup)
        {
            return _classGroupFacade.Create(classGroup);
        }
        
        public ClassGroupDto Update(ClassGroupDto classGroup)
        {
            return _classGroupFacade.Update(classGroup);
        }
        
        public void Delete(int id)
        {
            _classGroupFacade.Delete(id);
        }
    }
}