using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagementDBMS.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            Students = new HashSet<Student>();
            Exams = new HashSet<Exam>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public static implicit operator int(Subject v)
        {
            throw new NotImplementedException();
        }
    }
}