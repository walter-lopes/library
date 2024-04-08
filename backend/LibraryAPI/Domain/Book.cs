namespace LibraryAPI.Domain;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Publisher { get; set; }
    
    public int TotalCopies { get; set; }
    
    public int CopiesInUse { get; set; }
    public string Type { get; set; }
    public string Isbn { get; set; }
    public string Category { get; set; }


    public string GetAuthor()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetAvailableCopies()
    {
        return $"{CopiesInUse}/{TotalCopies}";
    }

    public void Rent()
    {
        CopiesInUse = CopiesInUse + 1;
    }

    public bool IsAllCopiesInUse()
    {
        return CopiesInUse == TotalCopies;
    }
}

public class AllCopiesUsedEvent
{
    public int BookId { get; set; }
}
