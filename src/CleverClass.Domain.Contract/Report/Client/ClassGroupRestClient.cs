using CleverClass.Domain.Contract.Report.Interface;
using CleverClass.Domain.Contract.Report.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CleverClass.Domain.Contract.Report.Client
{
    public class ClassGroupRestClient : IClassGroupFacade
    {
        public IEnumerable<ClassGroupDto> GetAll()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var jsonAsString = client.GetAsync("api/classgroup").Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ClassGroupDto>>(jsonAsString);
            }
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