using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class UserEntity
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string pwd { get; set; }

        public virtual AluminiEntity  Alumini { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<FeedbackEntity> Feedbacks { get; set; }
        public virtual StudentEntity Student { get; set; }
    }
}
