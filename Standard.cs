using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagementDBMS.Data.Entities
{
    public class Standard
    {
        public Standard()
        {
            Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public string StandardName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}