using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class StudentEntity:UserEntity
    {
        private string Address{get; set;}
        private string Classes { get; set; }
        private string CourseList { get; set; }
    }
}
