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
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(BaseDbContext baseDbContext)
            : base(baseDbContext)
        {
        }
    }
}