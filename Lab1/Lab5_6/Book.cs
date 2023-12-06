namespace Lab5_6;
public class Book : IEntity<int>, ICreationDate
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearOfPublication { get; set; }
}

