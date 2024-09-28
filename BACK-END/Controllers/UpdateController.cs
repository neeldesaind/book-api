using _23MCA028_Exam.Exceptions;
using _23MCA028_Exam.Models;
using System;
using System.Web.Http;

namespace _23MCA028_Exam.Controllers
{
    public class UpdateController : ApiController
    {
        Database_caseStudyEntities context = new Database_caseStudyEntities();

        [HttpPut]
        [Route("UpdateBook/{id}")] // Route for updating a book by ID
        public object UpdateBook(int id, TBLBookM updatedBook)
        {
            try
            {
                // Check if the updatedBook is null
                if (updatedBook == null)
                {
                    return new { output = false, message = "Updated book data is null." };
                }

                var existingBook = context.TBLBookMs.Find(id);
                if (existingBook == null)
                {
                    throw new BookNotFoundException(); // Assuming you have this custom exception class
                }

                // Update the existing book properties
                existingBook.name = updatedBook.name;
                existingBook.isbn = updatedBook.isbn;
                existingBook.price = updatedBook.price;
                existingBook.quantity = updatedBook.quantity;
                existingBook.author = updatedBook.author;

                context.SaveChanges();

                return new { output = true, message = "Book updated successfully." };
            }
            catch (BookNotFoundException ex)
            {
                return new { output = false, message = ex.Message };
            }
            catch (Exception ex)
            {
                // Log the exception
                // Return a generic error message
                return new { output = false, message = "An error occurred while updating the book." };
            }
        }
    }
}
