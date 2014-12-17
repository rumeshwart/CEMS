using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class StudentEntity:UserEntity
    {
        public int studentId { get; set; }
        public Nullable<int> userId { get; set; }
        public string address { get; set; }
        public string @class { get; set; }

        public virtual ICollection<EnrolledCours> EnrolledCourses { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual ICollection<SubmitedAssignment> SubmitedAssignments { get; set; }
    }
}
