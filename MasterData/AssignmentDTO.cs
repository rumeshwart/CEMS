using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    class AssignmentDTO
    {
        public int assignmentId { get; set; }
        public string assignmrtName { get; set; }
        public DateTime dueDate { get; set; }
        public int courseId { get; set; }
    }
}
