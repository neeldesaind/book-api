using _23MCA028_Exam.Exceptions;
using _23MCA028_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _23MCA028_Exam.Controllers
{
    public class DeleteController:ApiController

    {
        Database_caseStudyEntities context = new Database_caseStudyEntities();
        [HttpDelete]
        [Route("DeleteBook/{id}")] // Route for deleting a book by ID
        public object DeleteBook(int id)
        {
            try
            {
                var bookToDelete = context.TBLBookMs.Find(id);
                if (bookToDelete == null)
                {
                    throw new BookNotFoundException();
                }
                context.TBLBookMs.Remove(bookToDelete);
                context.SaveChanges();
                return new { output = true, message = "" };
            }
            catch (BookNotFoundException ex)
            {
                return new { output = false, message = ex.Message };
            }
        }
    }
}