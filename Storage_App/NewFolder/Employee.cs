using System;
namespace Storage_App.NewFolder
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }

        public override string ToString()=> $"Id: {Id}\tFull Name:{Fullname}";
    }
}
