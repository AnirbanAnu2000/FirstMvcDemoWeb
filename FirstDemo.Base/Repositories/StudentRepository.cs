using FirstDemo.Base.Data;
using FirstDemo.Base.DbContexts;
using FirstDemo.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Base.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(BaseDbContext baseDbContext)
            : base(baseDbContext)
        {
        }

    }
}