using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagementDBMS.Data.Entities
{
    public class ExamName
    {
        public ExamName()
        {
            Exams = new HashSet<Exam>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}