using CleverClass.Domain.Contract.Report.Dto;
using System.Collections.Generic;

namespace CleverClass.Domain.Contract.Report.Interface
{
    public interface IClassGroupFacade
    {
        IEnumerable<ClassGroupDto> GetAll();
        ClassGroupDto Get(int id);
        ClassGroupDto Create(ClassGroupDto classGroup);
        ClassGroupDto Update(ClassGroupDto classGroup);
        void Delete(int id);
    }
}
