**Book Management Application**
 This application allows users to manage book details through a simple interface.
  Features include adding, displaying, deleting, and updating book information.
  The backend is built using C# and an API, while the frontend is built using HTML, Bootstrap, and JavaScript.

**Features:**
**1. Enter Book Details**
   - Users can enter the following details for a book:
     - Book Name
     - ISBN
     - Price
     - Quantity
     - Author
     - The input fields are organized in a tab-wise manner for user convenience.
     - Book names must be unique; if a book with the same name exists, the entry will not be accepted.

**2. Show Data**
- Users can view all entered books in a tabular format.
- Each row will have a delete button to remove a specific book.

**3. Update Data**
- Users can select a book ID from a dropdown to automatically populate the book's details for updating.
- Users can modify the book's information and save changes.
- The same book name restriction applies during updates as well.

**API Details:**
- The application communicates with a C# backend API to handle book data.
- The API handles requests for adding, retrieving, updating, and deleting books.
- It ensures that book names remain unique by checking existing entries before adding new ones.

**Frontend Implementation:**
- HTML, Bootstrap, and JavaScript are used for a responsive and user-friendly interface.
- Bootstrap provides styling and layout management.
- JavaScript handles user interactions, form submissions, and API calls.

**Usage Instructions:**
 1. Clone the repository and open the HTML file in a web browser.
 2. Use the "Enter Book Details" tab to add new books.
 3. View existing books in the "Show Data" section.
 4. Use the "Update Data" tab to update book details by selecting a book ID from the dropdown.
 5. Delete a book by clicking the delete button next to its entry in the "Show Data" section.

**Example API Endpoints:**
 - POST /api/books/add: Adds a new book.
 - GET /api/books: Retrieves all books.
 - PUT /api/books/update: Updates a book's details.
 - DELETE /api/books/delete/{id}: Deletes a book by ID.

**Licsene:** [LICENSE](https://github.com/neeldesaind/book-api/blob/main/LICENSE)

**Note:**
 - Ensure the C# backend is running before using the application.
 - Adjust the API URLs in the frontend JavaScript code as needed based on your C# API setup.

**Video:**
