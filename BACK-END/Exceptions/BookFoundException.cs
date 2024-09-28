using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23MCA028_Exam.Exceptions
{
    public class BookFoundException:Exception
    {
        public BookFoundException() : base("Book Already Exists") { }
    }
}