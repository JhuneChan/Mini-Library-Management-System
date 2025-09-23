using System;

namespace miniLibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mini Library System!");
            
        }
    }

     class User
    {
        private string name { get; set; }
        private string id { get; set; }

        public User(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void Verify()
        {

        }
        class Account : User //inherits User
        {
            private int noOfBooksIssued { get; set; }
            private int noReserveredBooks { get; set; }
            private int noOfBooksReturned { get; set; }
            private int noOfLostBooks { get; set; }
            private double fineAmount { get; set; }

            //constructor
            public Account(string name, string id) : base(name,id)
            {
                noOfBooksIssued = 0;
                noReserveredBooks = 0;
                noOfBooksReturned = 0;
                noOfLostBooks = 0;
                fineAmount = 0.0;


            }
            //method
            public double CalculateFine(double fineAmount, int noOfLostBooks)
            {
                double totalFine = noOfLostBooks * fineAmount;
                return totalFine;
            }
        }
        

    }
     class Book
    {
        private string title { get; set; }
        private string author { get; set; }
        private string isbn { get; set; }
        private string publication { get; set; }

        //contructor
        public Book(string title, string author, string isbn, string publication)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.publication = publication;
        }

        protected void ShowDueDate()
        {
            // Implementation for showing due date
        }
        protected void ReservationStatus()
        {
            // Implementation for reservation status
        }
        protected void BookRequest()
        {
            // Implementation for book request  
        }
        protected void RenewInfo()
        {
            // Implementation for renew info
        }
    }
    
}
