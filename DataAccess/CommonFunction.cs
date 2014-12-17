using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    interface CommonFunction
    {
         void Insert();

         void Update();

         List<string> Select();

         void Delete();

         List<string> GetAll();

         List<string> GetById();
    }
}
