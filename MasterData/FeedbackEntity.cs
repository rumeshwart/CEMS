using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class FeedbackEntity
    {
        public int feedbackId { get; set; }
        public int userId { get; set; }
        public string feedBack1 { get; set; }
        public System.DateTime feedbackDate { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
