using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagementDBMS.Data.Entities
{
    public class Student
    {
        public Student()
        {
            Subjects = new HashSet<Subject>();
            Departments = new HashSet<Department>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int StandardId { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Standard Standard { get; set; }
    }
}