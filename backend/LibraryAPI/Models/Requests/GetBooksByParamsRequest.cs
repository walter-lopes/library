namespace LibraryAPI.Models.Requests;

public class GetBooksByParamsRequest
{
    public Filter Filter { get; set; }
    public string Value { get; set; }
}

public enum Filter
{
    ISBN = 1,
    Author = 2,
    Category = 3
}