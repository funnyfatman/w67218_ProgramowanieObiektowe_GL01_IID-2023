namespace Lab5_6;

    public class Person : IEntity<int>, ICreationDate
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; }
    }
