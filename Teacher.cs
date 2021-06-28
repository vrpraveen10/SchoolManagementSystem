using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using SchoolManagementDBMS.Data.Entities;

namespace SchoolManagementDBMS.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TableNumber { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }

    public class Teacher_config : EntityTypeConfiguration<Teacher>
    {
        public Teacher_config()
        {
            Property(e => e.Name).HasMaxLength(30);
            HasIndex(e => e.TableNumber).IsUnique();
        }
    }
}