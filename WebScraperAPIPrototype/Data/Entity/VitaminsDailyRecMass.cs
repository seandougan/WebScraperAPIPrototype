namespace WebScraperAPIPrototype.Data.Entity;

public class VitaminsDailyRecMass
{
    public long VitaminsDailyRecMassId { get; set; }
    public int VitaminB5 { get; set; }
    public int VitaminB6 { get; set; }
    public int VitaminB7 { get; set; }
    public int VitaminA { get; set; }
    public int VitaminC { get; set; }
    public int Calcium { get; set; }
    public int VitaminD { get; set; }
    public int VitaminE { get; set; }
    public int VitaminK { get; set; }
    public int VitaminB1 { get; set; }
    public int VitaminB2 { get; set; }
    public int VitaminB9 { get; set; }
    public int Iron { get; set; }
    public int Magnesium { get; set; }
    public int Sodium { get; set; }
    public int Zinc { get; set; }
    public int Phosphorus { get; set; }
    public int VitaminB12 { get; set; }
    public int Potassium { get; set; }
    public int Chromium { get; set; }
    public int Selenium { get; set; }
    public int VitaminB3 { get; set; }
    public int Iodine { get; set; }
    public DateTime CreatedDate{ get; set; }
    public int CreatedByUserId{ get; set; }
    public DateTime ModifiedDate{ get; set; }
    public int ModifiedByUserId{ get; set; }
    public bool UserDeleted{ get; set; }
    public DateTime DeletedDate{ get; set; }
    public string? DeletedReason{ get; set; }
}