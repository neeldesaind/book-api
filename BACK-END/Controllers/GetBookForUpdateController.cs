using _23MCA028_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _23MCA028_Exam.Controllers
{
    public class GetBookForUpdateController : ApiController
    {
        private Database_caseStudyEntities context;

        public GetBookForUpdateController()
        {
            context = new Database_caseStudyEntities();
        }

        [HttpGet]
        [Route("GetBookForUpdate/{id}")]
        public IHttpActionResult GetBookForUpdate(int id)
        {
            try
            {
                TBLBookM book = context.TBLBookMs.FirstOrDefault(b => b.id == id);
                if (book == null)
                {
                    return NotFound();
                }
                return Ok(book);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
