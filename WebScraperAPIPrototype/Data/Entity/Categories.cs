namespace WebScraperAPIPrototype.Data.Entity;

public class Categories
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public DateTime CreatedDate{ get; set; }
    public int CreatedByUserId{ get; set; }
    public DateTime ModifiedDate{ get; set; }
    public int ModifiedByUserId{ get; set; }
    public bool UserDeleted{ get; set; }
    public DateTime DeletedDate{ get; set; }
    public string? DeletedReason{ get; set; }
}