using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsSchool.Models;

namespace QuestionsSchool
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly QuestionsSchoolContext _context;

        public ApiController(QuestionsSchoolContext context)
        {
            _context = context;
        }

        private bool SchoolQuestionExists(int SchoolId,int QuestionId)
        {
            return _context.RelQuestSchool.Any(e => e.SchoolId == SchoolId && e.QuestionId==QuestionId);
        }

        // GET: GetSchool
        [Route("GetSchool")]
        [HttpGet]
        public IEnumerable<SchoolRel> GetSchool()
        {
            var schools= _context.School;

            var results =new List<SchoolRel>();

            IEnumerable<Question> quests = _context.Question;

            foreach (var s in schools)
            {
                var r = new SchoolRel() {
                     Id=s.Id,
                     Name=s.Name,
                     Description=s.Description
                };

                var questionsrels = new List<QuestionRel>();
                foreach (var q in quests) {
                    var qr = new QuestionRel();
                    qr.QuestionId = q.Id;
                    qr.IsRelated = SchoolQuestionExists(s.Id,q.Id);
                    questionsrels.Add(qr);
                };

                r.QuestionRels = questionsrels;
                results.Add(r);
            };

            return results;
        }
        //
        // GET: GetQuestions
        [Route("GetQuestions")]
        [HttpGet]
        public IEnumerable<Question> GetQuestions()
        {
            return _context.Question;
        }


        // GET: GetSchoolLike
        [Route("GetSchoolLike")]
        [HttpGet]
        public async Task<IActionResult> GetSchoolLike(string search)
        {
            var query = from e in _context.School
                        where EF.Functions.Like(e.Name, search + "%")
                        select e;
            return Ok(query);
        }

        // GET: api/Api/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSchool([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rel = from e in _context.RelQuestSchool
                      where e.School.Id == id
                      select e;

            return Ok(rel);
        }

    }
}