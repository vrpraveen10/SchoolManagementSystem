using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementDBMS.Data.Entities;

namespace SchoolManagementDBMS.Data
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            Builder.Configurations.Add(new Exam_config());
            Builder.Configurations.Add(new Teacher_config());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamName> ExamNames { get; set; }
    }
}
