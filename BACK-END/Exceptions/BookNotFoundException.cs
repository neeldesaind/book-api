using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23MCA028_Exam.Exceptions
{
    public class BookNotFoundException:Exception
    {
        public BookNotFoundException():base("Book Not found") { }
    }
}