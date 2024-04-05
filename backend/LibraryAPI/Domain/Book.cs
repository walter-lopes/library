namespace LibraryAPI.Domain;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    public string Title { get; set; }
    
    [Column("first_name")]
    public string FirstName { get; set; }
    
    [Column("last_name")]
    public string LastName { get; set; }
    
    public string Publisher { get; set; }
    
    [Column("total_copies")]
    public int TotalCopies { get; set; }
    
    [Column("copies_in_use")]
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
}
