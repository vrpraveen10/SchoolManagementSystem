using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagementDBMS.Data.Entities
{
    public class Exam
    {
        public Exam()
        {
            Subjects = new HashSet<Subject>();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double SubjectAverage { get; set; }

        public String SubjectName { get; set; }
        public virtual ExamName ExamName { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }

    public class Exam_config : EntityTypeConfiguration<Exam>
    {
        public Exam_config()
        {
            HasRequired(e => e.ExamName).WithMany(e => e.Exams).WillCascadeOnDelete(false);
        }
    }
}