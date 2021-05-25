using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsSchool.Models
{
    public class RelQuestSchool
    {
        public int Id { get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }
        public School School { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
