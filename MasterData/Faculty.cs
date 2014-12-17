﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterData
{
    public class Faculty : UserEntity 
    {
        public int facultyId { get; set; }
        public int userId { get; set; }
        public string department { get; set; }
        public string designation { get; set; }

        public virtual UserEntity User { get; set; }
      
    }
}
