using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23MCA028_Exam.Exceptions
{
    public class QuantityZeroException: Exception
    {
        public QuantityZeroException():base("Quantity must not be zero") { }
    }
}