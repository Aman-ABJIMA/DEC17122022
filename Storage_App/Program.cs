using Storage_App.NewFolder;
using Storage_App.repositories;
using System;
namespace Stroage_App
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericRepository employeeRepository1 = new GenericRepository<Employee>();
            var employeeRepository = employeeRepository1;
            employeeRepository1.Add(new Employee { Fullname = "AMAN SINGH" });
            employeeRepository1.Add(new Employee { Fullname = "KULDEEP SINGH" });
            employeeRepository1.Add(new Employee { Fullname = "ANISH KUMAR" });
            employeeRepository1.Save();
             
            var orginationRepository = new GenericRepository<Organization>();
            orginationRepository.Add(new Organization { Name = "ABJIMA" });
            orginationRepository.Add(new Organization { Name = "AITCS" });
          
        }
    }
}