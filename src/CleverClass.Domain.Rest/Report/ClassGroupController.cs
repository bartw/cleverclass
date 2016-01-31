using CleverClass.Domain.Contract.Report.Interface;
using CleverClass.Domain.Contract.Report.Dto;
using CleverClass.Domain.Business.Report;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CleverClass.Domain.Rest
{
    [Route("api/classgroup")]
    public class ClassGroupController : Controller, IClassGroupFacade
    {
        private readonly IClassGroupFacade _classGroupFacade;
        
        public ClassGroupController()
        {
            _classGroupFacade = new ClassGroupFacade();
        }
        
        [HttpGet]
        public IEnumerable<ClassGroupDto> GetAll()
        {
            return _classGroupFacade.GetAll();
        }
        
        [HttpGet("{id}")]
        public ClassGroupDto Get(int id)
        {
            return _classGroupFacade.Get(id);
        }
        
        [HttpPost]
        public ClassGroupDto Create(ClassGroupDto classGroup)
        {
            return _classGroupFacade.Create(classGroup);
        }
        
        [HttpPut("{id}")]
        public ClassGroupDto Update(ClassGroupDto classGroup)
        {
            return _classGroupFacade.Update(classGroup);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _classGroupFacade.Delete(id);
        }
    }
}