namespace Asssingment4
{
    using System;

    public class Book
    {
        // Properties
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int QuantityOfBooks { get; set; }
        public double BookPrice { get; set; }

        // Constructor
        public Book(string isbn, string bookName, string bookTitle, string bookAuthor, int quantityOfBooks, double bookPrice)
        {
            ISBN = isbn;
            BookName = bookName;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            QuantityOfBooks = quantityOfBooks;
            BookPrice = bookPrice;
        }

        // Method to calculate total price for the book
        public double CalculateTotalPrice()
        {
            return QuantityOfBooks * BookPrice;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Book Title: {BookTitle}");
            Console.WriteLine($"Book Author: {BookAuthor}");
            Console.WriteLine($"Quantity of Books: {QuantityOfBooks}");
            Console.WriteLine($"Book Price: {BookPrice:C}");
            Console.WriteLine($"Total Price: {CalculateTotalPrice():C}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Read the number of books from the user
            Console.Write("Enter the number of books: ");
            int numberOfBooks = int.Parse(Console.ReadLine());

            double totalBillAmount = 0;

            for (int i = 0; i < numberOfBooks; i++)
            {
                // Read book details from the user
                Console.WriteLine($"\nEnter details for book {i + 1}:");

                Console.Write("Enter ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string bookTitle = Console.ReadLine();

                Console.Write("Enter Book Author: ");
                string bookAuthor = Console.ReadLine();

                Console.Write("Enter Quantity of Books: ");
                int quantityOfBooks = int.Parse(Console.ReadLine());

                Console.Write("Enter Book Price: ");
                double bookPrice = double.Parse(Console.ReadLine());

                // Create a new book object
                Book book = new Book(isbn, bookName, bookTitle, bookAuthor, quantityOfBooks, bookPrice);

                // Display book details
                book.DisplayBookDetails();

                // Add to the total bill amount
                totalBillAmount += book.CalculateTotalPrice();
            }

            // Display the total bill amount
            Console.WriteLine($"\nTotal Bill Amount:{totalBillAmount:C}");
        }
    }


}
