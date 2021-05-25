using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsSchool.Models
{
    public class SchoolRel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<QuestionRel> QuestionRels { get; set; }
    }
}
