using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class AluminiEntity:UserEntity
    {
        public int aluminiId { get; set; }
        public Nullable<int> batchYear { get; set; }

        public virtual UserEntity User { get; set; }

    }
}
