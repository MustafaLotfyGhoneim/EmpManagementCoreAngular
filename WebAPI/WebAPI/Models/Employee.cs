
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string Title { get; set; }
        public string BirthDate { get; set; }
        public string HiringDate { get; set; }
        public string PhotoFileName { get; set; }

    }
}
