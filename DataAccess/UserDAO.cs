using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class UserDAO:CommonFunction 
    {
        StudentEnrollmentEntities entities = new StudentEnrollmentEntities();
        public void Insert(Student s)
        {
            entities.Students.Add(s);
            entities.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public List<string> Select()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<string> GetById()
        {
            throw new NotImplementedException();
        }
    }
}
