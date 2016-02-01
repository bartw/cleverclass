using CleverClass.Domain.Contract.Report.Client;
using CleverClass.Domain.Contract.Report.Dto;
using CleverClass.Domain.Contract.Report.Interface;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CleverClass.Domain.Rest
{
    [Route("api/classgroup")]
    public class ClassGroupController : Controller
    {
        private readonly IClassGroupFacade _classGroupClient;
        
        public ClassGroupController()
        {
            _classGroupClient = new ClassGroupRestClient();
        }
        
        [HttpGet]
        public IEnumerable<ClassGroupDto> GetAll()
        {
            return _classGroupClient.GetAll();
        }
        
        [HttpGet("{id}")]
        public ClassGroupDto Get(int id)
        {
            return _classGroupClient.Get(id);
        }
        
        [HttpPost]
        public ClassGroupDto Create(ClassGroupDto classGroup)
        {
            return _classGroupClient.Create(classGroup);
        }
        
        [HttpPut("{id}")]
        public ClassGroupDto Update(ClassGroupDto classGroup)
        {
            return _classGroupClient.Update(classGroup);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _classGroupClient.Delete(id);
        }
    }
}