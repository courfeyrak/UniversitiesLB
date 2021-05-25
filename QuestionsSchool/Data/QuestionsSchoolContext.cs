using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuestionsSchool.Models
{
    public class QuestionsSchoolContext : DbContext
    {
        public QuestionsSchoolContext (DbContextOptions<QuestionsSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<QuestionsSchool.Models.School> School { get; set; }
        public DbSet<QuestionsSchool.Models.Question> Question { get; set; }
        public DbSet<QuestionsSchool.Models.RelQuestSchool> RelQuestSchool { get; set; }


      
    }
}
