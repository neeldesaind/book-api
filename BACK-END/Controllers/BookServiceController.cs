using _23MCA028_Exam.Exceptions;
using _23MCA028_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _23MCA028_Exam.Controllers

{
    [EnableCors(origins: "http://127.0.0.1:5500", headers: "*", methods: "GET,POST")]
    public class BookServiceController:ApiController
    {
        Database_caseStudyEntities context = new Database_caseStudyEntities();
        [HttpGet]
        [Route("GetBooks")]
        public List<TBLBookM> BookList()
        {
            return context.TBLBookMs.ToList();
        }
        public object PostBook(TBLBookM book)
        {
            try
            {
                if (context.TBLBookMs.Any(b => b.name.ToLower() == book.name.ToLower()))
                {
                    throw new BookFoundException();
                }
                if (book.quantity <= 0)
                {
                    throw new QuantityZeroException();
                }
                context.TBLBookMs.Add(book);
                context.SaveChanges();
                return new { output = true, message = "" };
            }
            catch (BookFoundException ex)
            {
                return new { output = false, message = ex.Message };
            }
            catch (QuantityZeroException ex)
            {
                return new { output = false, message = ex.Message};
            }
        }
    }

}
