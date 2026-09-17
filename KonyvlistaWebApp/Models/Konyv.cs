namespace KonyvlistaWebApp.Models;

public class Konyv
{
    public int Id { get; set; }
    public string Cim { get; set; }
    public string Szerzo { get; set; }
    public int KiadasEve { get; set; }
    public decimal Ar { get; set; }
    
}